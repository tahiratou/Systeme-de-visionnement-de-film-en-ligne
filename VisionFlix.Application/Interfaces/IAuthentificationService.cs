using VisionFlix.Domain.Entities;

namespace VisionFlix.Application.Interfaces
{
    public interface IAuthentificationService
    {
        Utilisateur? CurrentUser { get; }
        Task<Utilisateur?> ConnecterAsync(string email, string motDePasse);
        void Deconnecter();
        bool EstConnecte();
        bool EstAdministrateur();
    }
}
