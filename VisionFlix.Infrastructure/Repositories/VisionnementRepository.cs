using Microsoft.EntityFrameworkCore;
using VisionFlix.Domain.Entities;
using VisionFlix.Domain.Interfaces;
using VisionFlix.Infrastructure.Data;

namespace VisionFlix.Infrastructure.Repositories
{
    public class VisionnementRepository : IVisionnementRepository
    {
        private readonly VisionFlixDbContext _context;

        public VisionnementRepository(VisionFlixDbContext context)
        {
            _context = context;
        }

        public async Task<Visionnement?> GetByIdAsync(int id)
        {
            return await _context.Visionnements
                .Include(v => v.Utilisateur)
                .Include(v => v.Film)
                .FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task<IEnumerable<Visionnement>> GetByUtilisateurIdAsync(int utilisateurId)
        {
            return await _context.Visionnements
                .Include(v => v.Film)
                .Where(v => v.UtilisateurId == utilisateurId)
                .OrderByDescending(v => v.DateVisionnement)
                .ToListAsync();
        }

        public async Task<IEnumerable<Visionnement>> GetByFilmIdAsync(int filmId)
        {
            return await _context.Visionnements
                .Include(v => v.Utilisateur)
                .Where(v => v.FilmId == filmId)
                .OrderByDescending(v => v.DateVisionnement)
                .ToListAsync();
        }

        public async Task<Visionnement> AddAsync(Visionnement visionnement)
        {
            _context.Visionnements.Add(visionnement);
            await _context.SaveChangesAsync();
            return visionnement;
        }

        public async Task UpdateAsync(Visionnement visionnement)
        {
            _context.Visionnements.Update(visionnement);
            await _context.SaveChangesAsync();
        }
    }
}