using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;

namespace VisionFlix.Core.Services
{
    /// <summary>
    /// Service Singleton qui stocke l'utilisateur connecté
    /// Pas de dépendances = pas de problème d'injection!
    /// </summary>
    public class SessionService : ISessionService
    {
        private Utilisateur? _currentUser;

        public Utilisateur? CurrentUser
        {
            get => _currentUser;
            set => _currentUser = value;
        }

        public bool IsAuthenticated => _currentUser != null;

        public bool IsAdministrator => _currentUser?.EstAdministrateur ?? false;

        public void ClearSession()
        {
            _currentUser = null;
        }
    }
}