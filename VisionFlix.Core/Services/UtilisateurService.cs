using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;

namespace VisionFlix.Core.Services
{
    public class UtilisateurService : IUtilisateurService
    {
        private readonly IUtilisateurRepository _utilisateurRepository;

        public UtilisateurService(IUtilisateurRepository utilisateurRepository)
        {
            _utilisateurRepository = utilisateurRepository;
        }

        public async Task<Utilisateur?> GetUtilisateurByIdAsync(int id)
        {
            return await _utilisateurRepository.GetByIdAsync(id);
        }

        public async Task<Utilisateur?> GetUtilisateurByEmailAsync(string email)
        {
            return await _utilisateurRepository.GetByEmailAsync(email);
        }

        public async Task<Utilisateur?> GetUtilisateurByNomUtilisateurAsync(string nomUtilisateur)
        {
            return await _utilisateurRepository.GetByNomUtilisateurAsync(nomUtilisateur);
        }

        public async Task<IEnumerable<Utilisateur>> GetAllUtilisateursAsync()
        {
            // ✅ CHANGEMENT: GetAllAsync() → ListAllAsync()
            return await _utilisateurRepository.ListAllAsync();
        }

        public async Task<Utilisateur> CreateUtilisateurAsync(Utilisateur utilisateur)
        {
            if (await _utilisateurRepository.EmailExistsAsync(utilisateur.Email))
            {
                throw new InvalidOperationException("Cet email est déjà utilisé.");
            }

            if (await _utilisateurRepository.NomUtilisateurExistsAsync(utilisateur.NomUtilisateur))
            {
                throw new InvalidOperationException("Ce nom d'utilisateur est déjà utilisé.");
            }

            if (string.IsNullOrWhiteSpace(utilisateur.NomUtilisateur) || utilisateur.NomUtilisateur.Length < 3)
            {
                throw new InvalidOperationException("Le nom d'utilisateur doit contenir au moins 3 caractères.");
            }

            if (string.IsNullOrWhiteSpace(utilisateur.Email))
            {
                throw new InvalidOperationException("L'email est obligatoire.");
            }

            if (string.IsNullOrWhiteSpace(utilisateur.MotDePasse))
            {
                throw new InvalidOperationException("Le mot de passe est obligatoire.");
            }

            utilisateur.DateInscription = DateTime.Now;
            utilisateur.EstAdministrateur = false;

            // ✅ CHANGEMENT: CreateAsync() → AddAsync()
            return await _utilisateurRepository.AddAsync(utilisateur);
        }

        public async Task UpdateUtilisateurAsync(Utilisateur utilisateur)
        {
            var existingUser = await _utilisateurRepository.GetByIdAsync(utilisateur.Id);
            if (existingUser == null)
            {
                throw new InvalidOperationException("Utilisateur introuvable.");
            }

            if (existingUser.Email != utilisateur.Email)
            {
                if (await _utilisateurRepository.EmailExistsAsync(utilisateur.Email))
                {
                    throw new InvalidOperationException("Cet email est déjà utilisé.");
                }
            }

            if (existingUser.NomUtilisateur != utilisateur.NomUtilisateur)
            {
                if (await _utilisateurRepository.NomUtilisateurExistsAsync(utilisateur.NomUtilisateur))
                {
                    throw new InvalidOperationException("Ce nom d'utilisateur est déjà utilisé.");
                }
            }

            await _utilisateurRepository.UpdateAsync(utilisateur);
        }

        public async Task DeleteUtilisateurAsync(int id)
        {
            var utilisateur = await _utilisateurRepository.GetByIdAsync(id);
            if (utilisateur == null)
            {
                throw new InvalidOperationException("Utilisateur introuvable.");
            }

            // ✅ CHANGEMENT: DeleteAsync(int id) → DeleteAsync(utilisateur)
            await _utilisateurRepository.DeleteAsync(utilisateur);
        }

        public async Task<bool> EmailExistsAsync(string email)
        {
            return await _utilisateurRepository.EmailExistsAsync(email);
        }

        public async Task<bool> NomUtilisateurExistsAsync(string nomUtilisateur)
        {
            return await _utilisateurRepository.NomUtilisateurExistsAsync(nomUtilisateur);
        }

        public async Task AjouterSoldeAsync(int utilisateurId, decimal montant)
        {
            var utilisateur = await _utilisateurRepository.GetByIdAsync(utilisateurId);
            if (utilisateur == null)
            {
                throw new InvalidOperationException("Utilisateur introuvable.");
            }

            if (montant <= 0)
            {
                throw new InvalidOperationException("Le montant doit être supérieur à zéro.");
            }

            utilisateur.Solde += montant;
            await _utilisateurRepository.UpdateAsync(utilisateur);
        }

        public async Task RetirerSoldeAsync(int utilisateurId, decimal montant)
        {
            var utilisateur = await _utilisateurRepository.GetByIdAsync(utilisateurId);
            if (utilisateur == null)
            {
                throw new InvalidOperationException("Utilisateur introuvable.");
            }

            if (montant <= 0)
            {
                throw new InvalidOperationException("Le montant doit être supérieur à zéro.");
            }

            if (utilisateur.Solde < montant)
            {
                throw new InvalidOperationException("Solde insuffisant.");
            }

            utilisateur.Solde -= montant;
            await _utilisateurRepository.UpdateAsync(utilisateur);
        }

        public async Task AbonnerAsync(int utilisateurId, int planAbonnementId)
        {
            var utilisateur = await _utilisateurRepository.GetByIdAsync(utilisateurId);
            if (utilisateur == null)
            {
                throw new InvalidOperationException("Utilisateur introuvable.");
            }

            utilisateur.EstAbonne = true;
            utilisateur.PlanAbonnementId = planAbonnementId;
            utilisateur.DateExpirationAbonnement = DateTime.Now.AddMonths(1);

            await _utilisateurRepository.UpdateAsync(utilisateur);
        }

        public async Task DesabonnerAsync(int utilisateurId)
        {
            var utilisateur = await _utilisateurRepository.GetByIdAsync(utilisateurId);
            if (utilisateur == null)
            {
                throw new InvalidOperationException("Utilisateur introuvable.");
            }

            utilisateur.EstAbonne = false;
            utilisateur.PlanAbonnementId = null;

            await _utilisateurRepository.UpdateAsync(utilisateur);
        }

        public async Task<bool> VerifierAbonnementActifAsync(int utilisateurId)
        {
            var utilisateur = await _utilisateurRepository.GetByIdAsync(utilisateurId);
            if (utilisateur == null)
            {
                return false;
            }

            if (utilisateur.EstAbonne &&
                utilisateur.DateExpirationAbonnement.HasValue &&
                utilisateur.DateExpirationAbonnement.Value > DateTime.Now)
            {
                return true;
            }

            return false;
        }
    }
}