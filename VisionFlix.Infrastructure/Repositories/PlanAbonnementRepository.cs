using Microsoft.EntityFrameworkCore;
using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;
using VisionFlix.Infrastructure.Data;

namespace VisionFlix.Infrastructure.Repositories
{
    public class PlanAbonnementRepository : EfRepository<PlanAbonnement>, IPlanAbonnementRepository
    {
        public PlanAbonnementRepository(VisionFlixDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<PlanAbonnement>> GetActiveAsync()
        {
            return await _context.PlansAbonnement
                .AsNoTracking()
                .Where(p => p.EstActif)
                .OrderBy(p => p.Prix)
                .ToListAsync();
        }

        public async Task<PlanAbonnement?> GetByNomAsync(string nom)
        {
            return await _context.PlansAbonnement
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Nom == nom);
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.PlansAbonnement
                .AsNoTracking()
                .AnyAsync(p => p.Id == id);
        }
    }
}