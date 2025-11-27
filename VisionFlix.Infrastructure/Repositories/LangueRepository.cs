using Microsoft.EntityFrameworkCore;
using VisionFlix.Domain.Entities;
using VisionFlix.Domain.Interfaces;
using VisionFlix.Infrastructure.Data;

namespace VisionFlix.Infrastructure.Repositories
{
    public class LangueRepository : ILangueRepository
    {
        private readonly VisionFlixDbContext _context;

        public LangueRepository(VisionFlixDbContext context)
        {
            _context = context;
        }

        public async Task<Langue?> GetByIdAsync(int id)
        {
            return await _context.Langues.FindAsync(id);
        }

        public async Task<IEnumerable<Langue>> GetAllAsync()
        {
            return await _context.Langues
                .OrderBy(l => l.Nom)
                .ToListAsync();
        }

        public async Task<IEnumerable<Langue>> GetActiveAsync()
        {
            return await _context.Langues
                .Where(l => l.EstActive)
                .OrderBy(l => l.Nom)
                .ToListAsync();
        }

        public async Task<Langue?> GetByCodeAsync(string code)
        {
            return await _context.Langues
                .FirstOrDefaultAsync(l => l.Code == code);
        }

        public async Task<Langue> AddAsync(Langue langue)
        {
            _context.Langues.Add(langue);
            await _context.SaveChangesAsync();
            return langue;
        }

        public async Task<Langue> UpdateAsync(Langue langue)
        {
            _context.Entry(langue).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return langue;
        }

        public async Task DeleteAsync(int id)
        {
            var langue = await _context.Langues.FindAsync(id);
            if (langue != null)
            {
                _context.Langues.Remove(langue);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Langues.AnyAsync(l => l.Id == id);
        }
    }
}
