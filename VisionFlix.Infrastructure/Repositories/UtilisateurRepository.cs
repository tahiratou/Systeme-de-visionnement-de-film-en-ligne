using Microsoft.EntityFrameworkCore;
using VisionFlix.Domain.Entities;
using VisionFlix.Domain.Interfaces;
using VisionFlix.Infrastructure.Data;

namespace VisionFlix.Infrastructure.Repositories
{
    public class UtilisateurRepository : IUtilisateurRepository
    {
        private readonly VisionFlixDbContext _context;

        public UtilisateurRepository(VisionFlixDbContext context)
        {
            _context = context;
        }

        public async Task<Utilisateur?> GetByIdAsync(int id)
        {
            return await _context.Utilisateurs
                .Include(u => u.PlanAbonnement)
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<Utilisateur?> GetByEmailAsync(string email)
        {
            return await _context.Utilisateurs
                .Include(u => u.PlanAbonnement)
                .FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<Utilisateur?> GetByNomUtilisateurAsync(string nomUtilisateur)
        {
            return await _context.Utilisateurs
                .Include(u => u.PlanAbonnement)
                .FirstOrDefaultAsync(u => u.NomUtilisateur == nomUtilisateur);
        }

        public async Task<IEnumerable<Utilisateur>> GetAllAsync()
        {
            return await _context.Utilisateurs
                .Include(u => u.PlanAbonnement)
                .ToListAsync();
        }

        public async Task<Utilisateur> CreateAsync(Utilisateur utilisateur)
        {
            _context.Utilisateurs.Add(utilisateur);
            await _context.SaveChangesAsync();
            return utilisateur;
        }

        public async Task UpdateAsync(Utilisateur utilisateur)
        {
            _context.Utilisateurs.Update(utilisateur);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var utilisateur = await GetByIdAsync(id);
            if (utilisateur != null)
            {
                _context.Utilisateurs.Remove(utilisateur);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> EmailExistsAsync(string email)
        {
            return await _context.Utilisateurs.AnyAsync(u => u.Email == email);
        }

        public async Task<bool> NomUtilisateurExistsAsync(string nomUtilisateur)
        {
            return await _context.Utilisateurs.AnyAsync(u => u.NomUtilisateur == nomUtilisateur);
        }
    }
}