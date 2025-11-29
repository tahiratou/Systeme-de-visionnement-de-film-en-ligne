using Microsoft.EntityFrameworkCore;
using VisionFlix.Domain.Entities;
using VisionFlix.Domain.Interfaces;
using VisionFlix.Infrastructure.Data;

namespace VisionFlix.Infrastructure.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        private readonly VisionFlixDbContext _context;

        public FilmRepository(VisionFlixDbContext context)
        {
            _context = context;
        }

        // ═══════════════════════════════════════════════════════════
        //  ✅ CORRECTION: Ajout de .AsNoTracking() sur GetByIdAsync
        // ═══════════════════════════════════════════════════════════

        public async Task<Film?> GetByIdAsync(int id)
        {
            return await _context.Films
                .AsNoTracking()  // ✅ AJOUT - Ne track pas cette instance
                .Include(f => f.Achats)
                .Include(f => f.Visionnements)
                .Include(f => f.Notations)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        // ═══════════════════════════════════════════════════════════
        //  ✅ CORRECTION: Ajout de .AsNoTracking() sur GetAllAsync
        // ═══════════════════════════════════════════════════════════

        public async Task<IEnumerable<Film>> GetAllAsync()
        {
            return await _context.Films
                .AsNoTracking()  // ✅ AJOUT - Ne track pas ces instances
                .Where(f => f.EstDisponible)
                .OrderByDescending(f => f.DateAjout)
                .ToListAsync();
        }

        // ═══════════════════════════════════════════════════════════
        //  ✅ CORRECTION: Ajout de .AsNoTracking() sur SearchAsync
        // ═══════════════════════════════════════════════════════════

        public async Task<IEnumerable<Film>> SearchAsync(string? titre, string? genre, int? annee, double? noteMinimum)
        {
            var query = _context.Films
                .AsNoTracking()  // ✅ AJOUT - Ne track pas ces instances
                .Where(f => f.EstDisponible);

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

        // ═══════════════════════════════════════════════════════════
        //  AddAsync - Pas de changement (doit tracker pour l'ID auto)
        // ═══════════════════════════════════════════════════════════

        public async Task<Film> AddAsync(Film film)
        {
            _context.Films.Add(film);
            await _context.SaveChangesAsync();
            return film;
        }

        // ═══════════════════════════════════════════════════════════
        //  ✅ CORRECTION: UpdateAsync avec détachement
        // ═══════════════════════════════════════════════════════════

        public async Task UpdateAsync(Film film)
        {
            // ✅ SOLUTION: Détacher toute instance existante avec le même Id
            var existingEntity = _context.Films.Local
                .FirstOrDefault(f => f.Id == film.Id);

            if (existingEntity != null)
            {
                // Détacher l'entité existante pour éviter le conflit
                _context.Entry(existingEntity).State = EntityState.Detached;
            }

            // Maintenant on peut update sans conflit
            _context.Films.Update(film);
            await _context.SaveChangesAsync();
        }

        // ═══════════════════════════════════════════════════════════
        //  DeleteAsync - Pas de changement (soft delete)
        // ═══════════════════════════════════════════════════════════

        public async Task DeleteAsync(int id)
        {
            var film = await _context.Films.FindAsync(id);
            if (film != null)
            {
                film.EstDisponible = false; // Soft delete
                await _context.SaveChangesAsync();
            }
        }

        // ═══════════════════════════════════════════════════════════
        //  ✅ CORRECTION: Ajout de .AsNoTracking() sur ExistsAsync
        // ═══════════════════════════════════════════════════════════

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Films
                .AsNoTracking()  // ✅ AJOUT - Ne track pas pour vérification
                .AnyAsync(f => f.Id == id);
        }
    }
}