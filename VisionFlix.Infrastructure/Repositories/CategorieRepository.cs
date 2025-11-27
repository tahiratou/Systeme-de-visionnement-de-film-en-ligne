using Microsoft.EntityFrameworkCore;
using VisionFlix.Domain.Entities;
using VisionFlix.Domain.Interfaces;
using VisionFlix.Infrastructure.Data;

namespace VisionFlix.Infrastructure.Repositories
{
    public class CategorieRepository : ICategorieRepository
    {
        private readonly VisionFlixDbContext _context;

        public CategorieRepository(VisionFlixDbContext context)
        {
            _context = context;
        }

        public async Task<Categorie?> GetByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<IEnumerable<Categorie>> GetAllAsync()
        {
            return await _context.Categories
                .OrderBy(c => c.Nom)
                .ToListAsync();
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

        public async Task<Categorie> AddAsync(Categorie categorie)
        {
            _context.Categories.Add(categorie);
            await _context.SaveChangesAsync();
            return categorie;
        }

        public async Task<Categorie> UpdateAsync(Categorie categorie)
        {
            _context.Entry(categorie).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return categorie;
        }

        public async Task DeleteAsync(int id)
        {
            var categorie = await _context.Categories.FindAsync(id);
            if (categorie != null)
            {
                _context.Categories.Remove(categorie);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Categories.AnyAsync(c => c.Id == id);
        }
    }
}
