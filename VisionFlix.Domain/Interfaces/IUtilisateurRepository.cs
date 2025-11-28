using VisionFlix.Domain.Entities;

namespace VisionFlix.Domain.Interfaces
{
    public interface IUtilisateurRepository
    {
        Task<Utilisateur?> GetByIdAsync(int id);
        Task<Utilisateur?> GetByEmailAsync(string email);

        Task<Utilisateur?> GetByNomUtilisateurAsync(string nomUtilisateur);

        Task<IEnumerable<Utilisateur>> GetAllAsync();
        Task<Utilisateur> CreateAsync(Utilisateur utilisateur);
        Task UpdateAsync(Utilisateur utilisateur);
        Task DeleteAsync(int id);

        Task<bool> EmailExistsAsync(string email);
        Task<bool> NomUtilisateurExistsAsync(string nomUtilisateur);
    }
}