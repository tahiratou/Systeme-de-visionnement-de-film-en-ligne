using Microsoft.EntityFrameworkCore;
using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;
using VisionFlix.Infrastructure.Data;

namespace VisionFlix.Infrastructure.Repositories
{
    public class NotationRepository : EfRepository<Notation>, INotationRepository
    {
        public NotationRepository(VisionFlixDbContext context) : base(context)
        {
        }

        public async Task<Notation?> GetByUtilisateurAndFilmAsync(int utilisateurId, int filmId)
        {
            return await _context.Notations
                .FirstOrDefaultAsync(n => n.UtilisateurId == utilisateurId && n.FilmId == filmId);
        }

        public async Task<IEnumerable<Notation>> GetByFilmIdAsync(int filmId)
        {
            return await _context.Notations
                .Include(n => n.Utilisateur)
                .Where(n => n.FilmId == filmId)
                .OrderByDescending(n => n.DateNotation)
                .ToListAsync();
        }
    }
}