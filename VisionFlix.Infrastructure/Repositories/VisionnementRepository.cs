using Microsoft.EntityFrameworkCore;
using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;
using VisionFlix.Infrastructure.Data;

namespace VisionFlix.Infrastructure.Repositories
{
    public class VisionnementRepository : EfRepository<Visionnement>, IVisionnementRepository
    {
        public VisionnementRepository(VisionFlixDbContext context) : base(context)
        {
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
    }
}

