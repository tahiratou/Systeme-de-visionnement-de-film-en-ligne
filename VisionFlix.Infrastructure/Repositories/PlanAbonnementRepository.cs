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
            // ? SOLUTION: Utiliser AsNoTracking() pour éviter les problèmes de threading
            // AsNoTracking() crée des entités en lecture seule qui ne sont pas trackées
            // par le DbContext, ce qui évite les conflits de threads
            return await _context.PlansAbonnement
                .AsNoTracking()              // ? Ajout d'AsNoTracking()
                .OrderBy(p => p.Prix)
                .ToListAsync();
        }

        public async Task<IEnumerable<PlanAbonnement>> GetActiveAsync()
        {
            // ? Même correction pour cette méthode
            return await _context.PlansAbonnement
                .AsNoTracking()              // ? Ajout d'AsNoTracking()
                .Where(p => p.EstActif)
                .OrderBy(p => p.Prix)
                .ToListAsync();
        }

        public async Task<PlanAbonnement?> GetByNomAsync(string nom)
        {
            // ? Même correction pour cette méthode
            return await _context.PlansAbonnement
                .AsNoTracking()              // ? Ajout d'AsNoTracking()
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