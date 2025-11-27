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

        public async Task<Utilisateur?> GetByEmailAsync(string email)
        {
            return await _context.Utilisateurs
                .Include(u => u.PlanAbonnement)
                .Include(u => u.Achats)
                .Include(u => u.Visionnements)
                .Include(u => u.Notations)
                .FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<Utilisateur?> AuthenticateAsync(string email, string password)
        {
            var utilisateur = await _context.Utilisateurs
                .Include(u => u.PlanAbonnement)
                .FirstOrDefaultAsync(u => u.Email == email && u.MotDePasse == password);

            if (utilisateur != null)
            {
                utilisateur.DerniereConnexion = DateTime.Now;
                await _context.SaveChangesAsync();
            }

            return utilisateur;
        }

        public async Task<Utilisateur?> GetByIdAsync(int id)
        {
            return await _context.Utilisateurs
                .Include(u => u.PlanAbonnement)
                .Include(u => u.Achats)
                .Include(u => u.Visionnements)
                .Include(u => u.Notations)
                .Include(u => u.Transactions)
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<IEnumerable<Utilisateur>> GetAllAsync()
        {
            return await _context.Utilisateurs
                .Include(u => u.PlanAbonnement)
                .ToListAsync();
        }

        public async Task<Utilisateur> AddAsync(Utilisateur utilisateur)
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
            var utilisateur = await _context.Utilisateurs.FindAsync(id);
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

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Utilisateurs.AnyAsync(u => u.Id == id);
        }
    }
}