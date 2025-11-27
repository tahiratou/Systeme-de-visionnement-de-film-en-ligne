using Microsoft.EntityFrameworkCore;
using VisionFlix.Domain.Entities;
using VisionFlix.Domain.Interfaces;
using VisionFlix.Infrastructure.Data;

namespace VisionFlix.Infrastructure.Repositories
{
    public class AchatRepository : IAchatRepository
    {
        private readonly VisionFlixDbContext _context;

        public AchatRepository(VisionFlixDbContext context)
        {
            _context = context;
        }

        public async Task<Achat?> GetByIdAsync(int id)
        {
            return await _context.Achats
                .Include(a => a.Utilisateur)
                .Include(a => a.Film)
                .FirstOrDefaultAsync(a => a.Id == id);
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

        public async Task<Achat> AddAsync(Achat achat)
        {
            _context.Achats.Add(achat);
            await _context.SaveChangesAsync();
            return achat;
        }

        public async Task<bool> UtilisateurHasAcheteFilmAsync(int utilisateurId, int filmId)
        {
            return await _context.Achats
                .AnyAsync(a => a.UtilisateurId == utilisateurId && a.FilmId == filmId);
        }
    }
}