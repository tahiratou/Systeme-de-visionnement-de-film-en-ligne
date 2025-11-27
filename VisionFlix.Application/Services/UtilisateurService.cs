using VisionFlix.Application.Interfaces;
using VisionFlix.Domain.Entities;
using VisionFlix.Domain.Interfaces;

namespace VisionFlix.Application.Services
{
    public class UtilisateurService : IUtilisateurService
    {
        private readonly IUtilisateurRepository _utilisateurRepository;
        private readonly IAchatRepository _achatRepository;
        private readonly ITransactionRepository _transactionRepository;

        public UtilisateurService(
            IUtilisateurRepository utilisateurRepository,
            IAchatRepository achatRepository,
            ITransactionRepository transactionRepository)
        {
            _utilisateurRepository = utilisateurRepository;
            _achatRepository = achatRepository;
            _transactionRepository = transactionRepository;
        }

        public async Task<Utilisateur?> GetUtilisateurByIdAsync(int id)
        {
            return await _utilisateurRepository.GetByIdAsync(id);
        }

        public async Task<Utilisateur?> GetUtilisateurByEmailAsync(string email)
        {
            return await _utilisateurRepository.GetByEmailAsync(email);
        }

        public async Task<Utilisateur> CreateUtilisateurAsync(Utilisateur utilisateur)
        {
            // Validation métier
            if (string.IsNullOrWhiteSpace(utilisateur.Email))
                throw new ArgumentException("L'email est requis.");

            if (string.IsNullOrWhiteSpace(utilisateur.MotDePasse))
                throw new ArgumentException("Le mot de passe est requis.");

            // Vérifier si l'email existe déjà
            var existingUser = await _utilisateurRepository.GetByEmailAsync(utilisateur.Email);
            if (existingUser != null)
                throw new InvalidOperationException("Un compte avec cet email existe déjà.");

            // Initialisation
            utilisateur.DateInscription = DateTime.Now;
            utilisateur.Solde = 0;
            utilisateur.EstAbonne = false;
            utilisateur.EstAdministrateur = false;

            return await _utilisateurRepository.AddAsync(utilisateur);
        }

        public async Task UpdateUtilisateurAsync(Utilisateur utilisateur)
        {
            var existing = await _utilisateurRepository.GetByIdAsync(utilisateur.Id);
            if (existing == null)
                throw new InvalidOperationException("Utilisateur introuvable.");

            await _utilisateurRepository.UpdateAsync(utilisateur);
        }

        public async Task<bool> AcheterFilmAsync(int utilisateurId, int filmId, decimal prixFilm)
        {
            var utilisateur = await _utilisateurRepository.GetByIdAsync(utilisateurId);
            if (utilisateur == null)
                throw new InvalidOperationException("Utilisateur introuvable.");

            // Vérifier si déjà acheté
            var dejaAchete = await _achatRepository.UtilisateurHasAcheteFilmAsync(utilisateurId, filmId);
            if (dejaAchete)
                throw new InvalidOperationException("Film déjà acheté.");

            // Vérifier le solde
            if (utilisateur.Solde < prixFilm)
                return false; // Solde insuffisant

            // Créer l'achat
            var achat = new Achat
            {
                UtilisateurId = utilisateurId,
                FilmId = filmId,
                DateAchat = DateTime.Now,
                Prix = prixFilm
            };
            await _achatRepository.AddAsync(achat);

            // Déduire du solde
            utilisateur.Solde -= prixFilm;
            await _utilisateurRepository.UpdateAsync(utilisateur);

            // Créer transaction
            var transaction = new Transaction
            {
                UtilisateurId = utilisateurId,
                Type = "Achat Film",
                Description = $"Achat film ID: {filmId}",
                DateTransaction = DateTime.Now,
                Montant = prixFilm
            };
            await _transactionRepository.AddAsync(transaction);

            return true;
        }

        public async Task<IEnumerable<Achat>> GetAchatsUtilisateurAsync(int utilisateurId)
        {
            return await _achatRepository.GetByUtilisateurIdAsync(utilisateurId);
        }

        public async Task<bool> UtilisateurPossedeFilmAsync(int utilisateurId, int filmId)
        {
            return await _achatRepository.UtilisateurHasAcheteFilmAsync(utilisateurId, filmId);
        }

        public async Task SouscrireAbonnementAsync(int utilisateurId, int planId, decimal prix)
        {
            var utilisateur = await _utilisateurRepository.GetByIdAsync(utilisateurId);
            if (utilisateur == null)
                throw new InvalidOperationException("Utilisateur introuvable.");

            if (utilisateur.Solde < prix)
                throw new InvalidOperationException("Solde insuffisant.");

            // Déduire du solde
            utilisateur.Solde -= prix;
            utilisateur.EstAbonne = true;
            utilisateur.PlanAbonnementId = planId;
            utilisateur.DateExpirationAbonnement = DateTime.Now.AddMonths(1);

            await _utilisateurRepository.UpdateAsync(utilisateur);

            // Créer transaction
            var transaction = new Transaction
            {
                UtilisateurId = utilisateurId,
                Type = "Abonnement",
                Description = $"Souscription plan ID: {planId}",
                DateTransaction = DateTime.Now,
                Montant = prix
            };
            await _transactionRepository.AddAsync(transaction);
        }

        public async Task<bool> EmailExistsAsync(string email)
        {
            return await _utilisateurRepository.EmailExistsAsync(email);
        }
    }
}