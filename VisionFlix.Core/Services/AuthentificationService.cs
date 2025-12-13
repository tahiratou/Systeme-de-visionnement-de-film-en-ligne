using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;

namespace VisionFlix.Core.Services
{
    public class AuthentificationService : IAuthentificationService
    {
        private readonly IUtilisateurRepository _utilisateurRepository;
        private readonly ISessionService _sessionService;

        public AuthentificationService(IUtilisateurRepository utilisateurRepository, ISessionService sessionService)
        {
            _utilisateurRepository = utilisateurRepository;
            _sessionService = sessionService;
        }

        public Utilisateur? CurrentUser => _sessionService.CurrentUser;

        public async Task<Utilisateur?> ConnecterAsync(string identifiant, string motDePasse)
        {

            var utilisateur = await _utilisateurRepository.GetByNomUtilisateurAsync(identifiant);

            if (utilisateur != null && utilisateur.MotDePasse == motDePasse)
            {
                _sessionService.CurrentUser = utilisateur;

                utilisateur.DerniereConnexion = DateTime.Now;
                await _utilisateurRepository.UpdateAsync(utilisateur);

                return utilisateur;
            }

            return null;
        }

        public void Deconnecter()
        {
            _sessionService.ClearSession();
        }

        public bool EstConnecte()
        {
            return _sessionService.IsAuthenticated;
        }

        public bool EstAdministrateur()
        {
            return _sessionService.IsAdministrator;
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