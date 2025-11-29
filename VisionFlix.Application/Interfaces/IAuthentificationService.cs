using VisionFlix.Domain.Entities;

namespace VisionFlix.Application.Interfaces
{
    public interface IAuthentificationService
    {
        Utilisateur? CurrentUser { get; }
        Task<Utilisateur?> ConnecterAsync(string identifiant, string motDePasse);
        void Deconnecter();
        bool EstConnecte();
        bool EstAdministrateur();
        Task<bool> ValiderMotDePasseAsync(string identifiant, string motDePasse);
    }
}
