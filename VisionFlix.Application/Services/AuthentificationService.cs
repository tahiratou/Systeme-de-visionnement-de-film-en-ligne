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

        public async Task<Utilisateur?> ConnecterAsync(string email, string motDePasse)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(motDePasse))
                return null;

            var utilisateur = await _utilisateurRepository.AuthenticateAsync(email, motDePasse);

            if (utilisateur != null)
            {
                _currentUser = utilisateur;
            }

            return utilisateur;
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
    }
}