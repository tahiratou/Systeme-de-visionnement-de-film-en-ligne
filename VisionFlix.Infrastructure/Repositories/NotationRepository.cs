using Microsoft.EntityFrameworkCore;
using VisionFlix.Domain.Entities;
using VisionFlix.Domain.Interfaces;
using VisionFlix.Infrastructure.Data;

namespace VisionFlix.Infrastructure.Repositories
{
    public class NotationRepository : INotationRepository
    {
        private readonly VisionFlixDbContext _context;

        public NotationRepository(VisionFlixDbContext context)
        {
            _context = context;
        }

        public async Task<Notation?> GetByIdAsync(int id)
        {
            return await _context.Notations
                .Include(n => n.Utilisateur)
                .Include(n => n.Film)
                .FirstOrDefaultAsync(n => n.Id == id);
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

        public async Task<Notation> AddAsync(Notation notation)
        {
            _context.Notations.Add(notation);
            await _context.SaveChangesAsync();
            return notation;
        }

        public async Task UpdateAsync(Notation notation)
        {
            _context.Notations.Update(notation);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var notation = await _context.Notations.FindAsync(id);
            if (notation != null)
            {
                _context.Notations.Remove(notation);
                await _context.SaveChangesAsync();
            }
        }
    }
}