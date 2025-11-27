using VisionFlix.Domain.Entities;

namespace VisionFlix.Domain.Interfaces
{
    public interface IPlanAbonnementRepository
    {
        Task<PlanAbonnement?> GetByIdAsync(int id);
        Task<IEnumerable<PlanAbonnement>> GetAllAsync();
        Task<IEnumerable<PlanAbonnement>> GetActiveAsync();
        Task<PlanAbonnement?> GetByNomAsync(string nom);
        Task<PlanAbonnement> AddAsync(PlanAbonnement planAbonnement);
        Task<PlanAbonnement> UpdateAsync(PlanAbonnement planAbonnement);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
