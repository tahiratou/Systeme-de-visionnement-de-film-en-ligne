using VisionFlix.Core.Entities;

namespace VisionFlix.Core.Interfaces
{
    /// <summary>
    /// Service Singleton qui garde l'utilisateur connecté en mémoire
    /// </summary>
    public interface ISessionService
    {
        Utilisateur? CurrentUser { get; set; }
        bool IsAuthenticated { get; }
        bool IsAdministrator { get; }
        void ClearSession();
    }
}