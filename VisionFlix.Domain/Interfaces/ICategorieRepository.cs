using VisionFlix.Domain.Entities;

namespace VisionFlix.Domain.Interfaces
{
    public interface ICategorieRepository
    {
        Task<Categorie?> GetByIdAsync(int id);
        Task<IEnumerable<Categorie>> GetAllAsync();
        Task<IEnumerable<Categorie>> GetActiveAsync();
        Task<Categorie?> GetByNomAsync(string nom);
        Task<Categorie> AddAsync(Categorie categorie);
        Task<Categorie> UpdateAsync(Categorie categorie);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
