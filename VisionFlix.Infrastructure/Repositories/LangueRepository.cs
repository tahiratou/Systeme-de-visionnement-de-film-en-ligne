using Microsoft.EntityFrameworkCore;
using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;
using VisionFlix.Infrastructure.Data;

namespace VisionFlix.Infrastructure.Repositories
{
    public class LangueRepository : EfRepository<Langue>, ILangueRepository
    {
        public LangueRepository(VisionFlixDbContext context) : base(context)
        {
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

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Langues.AnyAsync(l => l.Id == id);
        }
    }
}