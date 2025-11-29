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


        public async Task<Film?> GetByIdAsync(int id)
        {
            return await _context.Films
                .AsNoTracking() 
                .Include(f => f.Achats)
                .Include(f => f.Visionnements)
                .Include(f => f.Notations)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

       
        public async Task<IEnumerable<Film>> GetAllAsync()
        {
            return await _context.Films
                .AsNoTracking()  
                .Where(f => f.EstDisponible)
                .OrderByDescending(f => f.DateAjout)
                .ToListAsync();
        }

        
        public async Task<IEnumerable<Film>> SearchAsync(string? titre, string? genre, int? annee, double? noteMinimum)
        {
            var query = _context.Films
                .AsNoTracking()  
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

        
        public async Task<Film> AddAsync(Film film)
        {
            _context.Films.Add(film);
            await _context.SaveChangesAsync();
            return film;
        }

       
        public async Task UpdateAsync(Film film)
        {
            var existingEntity = _context.Films.Local
                .FirstOrDefault(f => f.Id == film.Id);

            if (existingEntity != null)
            {
                _context.Entry(existingEntity).State = EntityState.Detached;
            }

            _context.Films.Update(film);
            await _context.SaveChangesAsync();
        }

        
        public async Task DeleteAsync(int id)
        {
            var film = await _context.Films.FindAsync(id);
            if (film != null)
            {
                film.EstDisponible = false; 
                await _context.SaveChangesAsync();
            }
        }


        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Films
                .AsNoTracking()  
                .AnyAsync(f => f.Id == id);
        }
    }
}