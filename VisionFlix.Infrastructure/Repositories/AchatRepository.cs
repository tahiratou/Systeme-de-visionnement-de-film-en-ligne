using Microsoft.EntityFrameworkCore;
using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;
using VisionFlix.Infrastructure.Data;

namespace VisionFlix.Infrastructure.Repositories
{
    public class AchatRepository : EfRepository<Achat>, IAchatRepository
    {
        public AchatRepository(VisionFlixDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Achat>> GetByUtilisateurIdAsync(int utilisateurId)
        {
            return await _context.Achats
                .Include(a => a.Film)
                .Where(a => a.UtilisateurId == utilisateurId)
                .OrderByDescending(a => a.DateAchat)
                .ToListAsync();
        }

        public async Task<Achat?> GetByUtilisateurAndFilmAsync(int utilisateurId, int filmId)
        {
            return await _context.Achats
                .FirstOrDefaultAsync(a => a.UtilisateurId == utilisateurId && a.FilmId == filmId);
        }

        public async Task<bool> UtilisateurHasAcheteFilmAsync(int utilisateurId, int filmId)
        {
            return await _context.Achats
                .AnyAsync(a => a.UtilisateurId == utilisateurId && a.FilmId == filmId);
        }
    }
}