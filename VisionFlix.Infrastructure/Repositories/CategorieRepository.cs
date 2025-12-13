using Microsoft.EntityFrameworkCore;
using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;
using VisionFlix.Infrastructure.Data;

namespace VisionFlix.Infrastructure.Repositories
{
    public class CategorieRepository : EfRepository<Categorie>, ICategorieRepository
    {
        public CategorieRepository(VisionFlixDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Categorie>> GetActiveAsync()
        {
            return await _context.Categories
                .Where(c => c.EstActive)
                .OrderBy(c => c.Nom)
                .ToListAsync();
        }

        public async Task<Categorie?> GetByNomAsync(string nom)
        {
            return await _context.Categories
                .FirstOrDefaultAsync(c => c.Nom == nom);
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Categories.AnyAsync(c => c.Id == id);
        }
    }
}

