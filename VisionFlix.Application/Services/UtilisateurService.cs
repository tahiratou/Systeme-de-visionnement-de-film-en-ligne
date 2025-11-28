using VisionFlix.Application.Interfaces;
using VisionFlix.Domain.Entities;
using VisionFlix.Domain.Interfaces;

namespace VisionFlix.Application.Services
{
    public class UtilisateurService : IUtilisateurService
    {
        private readonly IUtilisateurRepository _utilisateurRepository;

        public UtilisateurService(IUtilisateurRepository utilisateurRepository)
        {
            _utilisateurRepository = utilisateurRepository;
        }

        // ===== RÉCUPÉRATION =====

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
            return await _utilisateurRepository.GetAllAsync();
        }

        // ===== CRÉATION =====

        public async Task<Utilisateur> CreateUtilisateurAsync(Utilisateur utilisateur)
        {
            // Validation: Vérifier que l'email n'existe pas déjà
            if (await _utilisateurRepository.EmailExistsAsync(utilisateur.Email))
            {
                throw new InvalidOperationException("Cet email est déjà utilisé.");
            }

            // Validation: Vérifier que le nom d'utilisateur n'existe pas déjà
            if (await _utilisateurRepository.NomUtilisateurExistsAsync(utilisateur.NomUtilisateur))
            {
                throw new InvalidOperationException("Ce nom d'utilisateur est déjà utilisé.");
            }

            // Validation: Nom d'utilisateur doit avoir au moins 3 caractères
            if (string.IsNullOrWhiteSpace(utilisateur.NomUtilisateur) || utilisateur.NomUtilisateur.Length < 3)
            {
                throw new InvalidOperationException("Le nom d'utilisateur doit contenir au moins 3 caractères.");
            }

            // Validation: Email ne doit pas être vide
            if (string.IsNullOrWhiteSpace(utilisateur.Email))
            {
                throw new InvalidOperationException("L'email est obligatoire.");
            }

            // Validation: Mot de passe ne doit pas être vide
            if (string.IsNullOrWhiteSpace(utilisateur.MotDePasse))
            {
                throw new InvalidOperationException("Le mot de passe est obligatoire.");
            }

            // Définir la date d'inscription
            utilisateur.DateInscription = DateTime.Now;

            // Par défaut, un nouvel utilisateur n'est pas administrateur
            utilisateur.EstAdministrateur = false;

            // Créer l'utilisateur
            return await _utilisateurRepository.CreateAsync(utilisateur);
        }

        // ===== MISE À JOUR =====

        public async Task UpdateUtilisateurAsync(Utilisateur utilisateur)
        {
            // Vérifier que l'utilisateur existe
            var existingUser = await _utilisateurRepository.GetByIdAsync(utilisateur.Id);
            if (existingUser == null)
            {
                throw new InvalidOperationException("Utilisateur introuvable.");
            }

            // Si l'email a changé, vérifier qu'il n'est pas déjà utilisé
            if (existingUser.Email != utilisateur.Email)
            {
                if (await _utilisateurRepository.EmailExistsAsync(utilisateur.Email))
                {
                    throw new InvalidOperationException("Cet email est déjà utilisé.");
                }
            }

            // Si le nom d'utilisateur a changé, vérifier qu'il n'est pas déjà utilisé
            if (existingUser.NomUtilisateur != utilisateur.NomUtilisateur)
            {
                if (await _utilisateurRepository.NomUtilisateurExistsAsync(utilisateur.NomUtilisateur))
                {
                    throw new InvalidOperationException("Ce nom d'utilisateur est déjà utilisé.");
                }
            }

            await _utilisateurRepository.UpdateAsync(utilisateur);
        }

        // ===== SUPPRESSION =====

        public async Task DeleteUtilisateurAsync(int id)
        {
            var utilisateur = await _utilisateurRepository.GetByIdAsync(id);
            if (utilisateur == null)
            {
                throw new InvalidOperationException("Utilisateur introuvable.");
            }

            await _utilisateurRepository.DeleteAsync(id);
        }

        // ===== VÉRIFICATIONS =====

        public async Task<bool> EmailExistsAsync(string email)
        {
            return await _utilisateurRepository.EmailExistsAsync(email);
        }

        public async Task<bool> NomUtilisateurExistsAsync(string nomUtilisateur)
        {
            return await _utilisateurRepository.NomUtilisateurExistsAsync(nomUtilisateur);
        }

        // ===== GESTION DU SOLDE =====

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

        // ===== GESTION DE L'ABONNEMENT =====

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
            // Note: On garde DateExpirationAbonnement pour historique

            await _utilisateurRepository.UpdateAsync(utilisateur);
        }

        public async Task<bool> VerifierAbonnementActifAsync(int utilisateurId)
        {
            var utilisateur = await _utilisateurRepository.GetByIdAsync(utilisateurId);
            if (utilisateur == null)
            {
                return false;
            }

            // Vérifier si l'utilisateur est abonné ET que l'abonnement n'a pas expiré
            if (utilisateur.EstAbonne &&
                utilisateur.DateExpirationAbonnement.HasValue &&
                utilisateur.DateExpirationAbonnement.Value > DateTime.Now)
            {
                return true;
            }

            // Si l'abonnement a expiré, le désactiver automatiquement
            if (utilisateur.EstAbonne &&
                utilisateur.DateExpirationAbonnement.HasValue &&
                utilisateur.DateExpirationAbonnement.Value <= DateTime.Now)
            {
                utilisateur.EstAbonne = false;
                await _utilisateurRepository.UpdateAsync(utilisateur);
            }

            return false;
        }
    }
}