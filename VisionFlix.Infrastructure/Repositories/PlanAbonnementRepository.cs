using Microsoft.EntityFrameworkCore;
using VisionFlix.Domain.Entities;
using VisionFlix.Domain.Interfaces;
using VisionFlix.Infrastructure.Data;

namespace VisionFlix.Infrastructure.Repositories
{
    public class PlanAbonnementRepository : IPlanAbonnementRepository
    {
        private readonly VisionFlixDbContext _context;

        public PlanAbonnementRepository(VisionFlixDbContext context)
        {
            _context = context;
        }

        public async Task<PlanAbonnement?> GetByIdAsync(int id)
        {
            return await _context.PlansAbonnement.FindAsync(id);
        }

        public async Task<IEnumerable<PlanAbonnement>> GetAllAsync()
        {
      
            return await _context.PlansAbonnement
                .AsNoTracking()             
                .OrderBy(p => p.Prix)
                .ToListAsync();
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

        public async Task<PlanAbonnement> AddAsync(PlanAbonnement planAbonnement)
        {
            _context.PlansAbonnement.Add(planAbonnement);
            await _context.SaveChangesAsync();
            return planAbonnement;
        }

        public async Task<PlanAbonnement> UpdateAsync(PlanAbonnement planAbonnement)
        {
            _context.Entry(planAbonnement).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return planAbonnement;
        }

        public async Task DeleteAsync(int id)
        {
            var planAbonnement = await _context.PlansAbonnement.FindAsync(id);
            if (planAbonnement != null)
            {
                _context.PlansAbonnement.Remove(planAbonnement);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.PlansAbonnement
                .AsNoTracking()
                .AnyAsync(p => p.Id == id);
        }
    }
}