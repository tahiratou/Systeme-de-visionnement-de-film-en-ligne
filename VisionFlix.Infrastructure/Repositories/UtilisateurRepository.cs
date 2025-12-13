using Microsoft.EntityFrameworkCore;
using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;
using VisionFlix.Infrastructure.Data;

namespace VisionFlix.Infrastructure.Repositories
{
    public class UtilisateurRepository : EfRepository<Utilisateur>, IUtilisateurRepository
    {
        public UtilisateurRepository(VisionFlixDbContext context) : base(context)
        {
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