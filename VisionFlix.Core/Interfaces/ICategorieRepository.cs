using VisionFlix.Core.Entities;
using VisionFlix.SharedKernel.Interfaces;  

namespace VisionFlix.Core.Interfaces
{
    public interface ICategorieRepository : IAsyncRepository<Categorie>, IRepository<Categorie> 
    {

        Task<IEnumerable<Categorie>> GetActiveAsync();
        Task<Categorie?> GetByNomAsync(string nom);
        Task<bool> ExistsAsync(int id);
    }
}