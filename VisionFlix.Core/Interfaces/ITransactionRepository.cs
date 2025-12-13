using VisionFlix.Core.Entities;
using VisionFlix.SharedKernel.Interfaces;  

namespace VisionFlix.Core.Interfaces
{
    public interface ITransactionRepository : IAsyncRepository<Transaction>, IRepository<Transaction>  
    {

        Task<IEnumerable<Transaction>> GetByUtilisateurIdAsync(int utilisateurId);
        Task<IEnumerable<Transaction>> GetByTypeAsync(string type);
        Task<IEnumerable<Transaction>> GetByDateRangeAsync(DateTime debut, DateTime fin);
    }
}