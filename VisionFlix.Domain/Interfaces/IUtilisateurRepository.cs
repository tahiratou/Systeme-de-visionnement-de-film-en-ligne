using VisionFlix.Domain.Entities;

namespace VisionFlix.Domain.Interfaces
{
    public interface IUtilisateurRepository
    {
        // Authentification
        Task<Utilisateur?> GetByEmailAsync(string email);
        Task<Utilisateur?> AuthenticateAsync(string email, string password);

        // CRUD
        Task<Utilisateur?> GetByIdAsync(int id);
        Task<IEnumerable<Utilisateur>> GetAllAsync();
        Task<Utilisateur> AddAsync(Utilisateur utilisateur);
        Task UpdateAsync(Utilisateur utilisateur);
        Task DeleteAsync(int id);

        // Vérifications
        Task<bool> EmailExistsAsync(string email);
        Task<bool> ExistsAsync(int id);
    }
}