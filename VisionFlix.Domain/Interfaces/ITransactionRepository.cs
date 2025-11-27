using VisionFlix.Domain.Entities;

namespace VisionFlix.Domain.Interfaces
{
    public interface ITransactionRepository
    {
        Task<Transaction?> GetByIdAsync(int id);
        Task<IEnumerable<Transaction>> GetAllAsync();
        Task<IEnumerable<Transaction>> GetByUtilisateurIdAsync(int utilisateurId);
        Task<IEnumerable<Transaction>> GetByTypeAsync(string type);
        Task<IEnumerable<Transaction>> GetByDateRangeAsync(DateTime debut, DateTime fin);
        Task<Transaction> AddAsync(Transaction transaction);
        Task<Transaction> UpdateAsync(Transaction transaction);
        Task DeleteAsync(int id);
    }
}