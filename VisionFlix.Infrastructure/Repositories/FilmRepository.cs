using Microsoft.EntityFrameworkCore;
using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;
using VisionFlix.Infrastructure.Data;

namespace VisionFlix.Infrastructure.Repositories
{
    public class FilmRepository : EfRepository<Film>, IFilmRepository
    {
        public FilmRepository(VisionFlixDbContext context) : base(context)
        {
        }

        public async Task<Film?> GetById(int id)
        {
            return await _context.Films
                .AsNoTracking()
                .Include(f => f.Achats)
                .Include(f => f.Visionnements)
                .Include(f => f.Notations)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<IEnumerable<Film>> SearchAsync(string? titre, string? genre, int? annee, double? noteMinimum)
        {
            var query = _context.Films.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(titre))
            {
                query = query.Where(f => f.Titre.Contains(titre) || f.Realisateur.Contains(titre));
            }

            if (!string.IsNullOrWhiteSpace(genre) && genre != "Tous")
            {
                query = query.Where(f => f.Genre == genre);
            }

            if (annee.HasValue)
            {
                query = query.Where(f => f.Annee == annee.Value);
            }

            if (noteMinimum.HasValue)
            {
                query = query.Where(f => f.Note >= noteMinimum.Value);
            }

            return await query.OrderByDescending(f => f.Note).ToListAsync();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Films
                .AsNoTracking()
                .AnyAsync(f => f.Id == id);
        }
    }
}
