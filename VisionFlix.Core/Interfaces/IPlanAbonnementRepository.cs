using VisionFlix.Core.Entities;
using VisionFlix.SharedKernel.Interfaces; 

namespace VisionFlix.Core.Interfaces
{
    public interface IPlanAbonnementRepository : IAsyncRepository<PlanAbonnement>, IRepository<PlanAbonnement> 
    {

        Task<IEnumerable<PlanAbonnement>> GetActiveAsync();
        Task<PlanAbonnement?> GetByNomAsync(string nom);
        Task<bool> ExistsAsync(int id);
    }
}