using VisionFlix.Domain.Entities;

namespace VisionFlix.Domain.Interfaces
{
    public interface ILangueRepository
    {
        Task<Langue?> GetByIdAsync(int id);
        Task<IEnumerable<Langue>> GetAllAsync();
        Task<IEnumerable<Langue>> GetActiveAsync();
        Task<Langue?> GetByCodeAsync(string code);
        Task<Langue> AddAsync(Langue langue);
        Task<Langue> UpdateAsync(Langue langue);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
