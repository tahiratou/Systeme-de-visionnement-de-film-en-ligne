using VisionFlix.Core.Entities;
using VisionFlix.SharedKernel.Interfaces; 

namespace VisionFlix.Core.Interfaces
{
    public interface ILangueRepository : IAsyncRepository<Langue>, IRepository<Langue> 
    {

        Task<IEnumerable<Langue>> GetActiveAsync();
        Task<Langue?> GetByCodeAsync(string code);
        Task<bool> ExistsAsync(int id);
    }
}