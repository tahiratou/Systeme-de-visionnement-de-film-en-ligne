using VisionFlix.Application.Interfaces;
using VisionFlix.Domain.Entities;
using VisionFlix.Domain.Interfaces;

namespace VisionFlix.Application.Services
{
    public class AuthentificationService : IAuthentificationService
    {
        private readonly IUtilisateurRepository _utilisateurRepository;
        private Utilisateur? _currentUser;

        public AuthentificationService(IUtilisateurRepository utilisateurRepository)
        {
            _utilisateurRepository = utilisateurRepository;
        }

        public Utilisateur? CurrentUser => _currentUser;

        public async Task<Utilisateur?> ConnecterAsync(string identifiant, string motDePasse)
        {
            // ❌ ERREUR CORRIGÉE: Utilise _utilisateurRepository au lieu de _context

            // Chercher par NomUtilisateur (comme demandé - pas d'email!)
            var utilisateur = await _utilisateurRepository.GetByNomUtilisateurAsync(identifiant);

            // Vérifier le mot de passe
            if (utilisateur != null && utilisateur.MotDePasse == motDePasse)
            {
                // ✅ Mettre à jour la session actuelle
                _currentUser = utilisateur;

                // ✅ Mettre à jour la date de dernière connexion
                utilisateur.DerniereConnexion = DateTime.Now;
                await _utilisateurRepository.UpdateAsync(utilisateur);

                return utilisateur;
            }

            return null;
        }

        public void Deconnecter()
        {
            _currentUser = null;
        }

        public bool EstConnecte()
        {
            return _currentUser != null;
        }

        public bool EstAdministrateur()
        {
            return _currentUser?.EstAdministrateur ?? false;
        }

        public async Task<bool> ValiderMotDePasseAsync(string email, string motDePasse)
        {
            var utilisateur = await _utilisateurRepository.GetByEmailAsync(email);

            if (utilisateur == null)
            {
                return false;
            }

            return utilisateur.MotDePasse == motDePasse;
        }
    }
}