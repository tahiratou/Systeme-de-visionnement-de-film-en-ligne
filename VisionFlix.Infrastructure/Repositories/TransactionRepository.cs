using Microsoft.EntityFrameworkCore;
using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;
using VisionFlix.Infrastructure.Data;

namespace VisionFlix.Infrastructure.Repositories
{
    public class TransactionRepository : EfRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(VisionFlixDbContext context) : base(context)
        {
        }


        public async Task<IEnumerable<Transaction>> GetByUtilisateurIdAsync(int utilisateurId)
        {
            return await _context.Transactions
                .Include(t => t.Utilisateur)
                .Where(t => t.UtilisateurId == utilisateurId)
                .OrderByDescending(t => t.DateTransaction)
                .ToListAsync();
        }

        public async Task<IEnumerable<Transaction>> GetByTypeAsync(string type)
        {
            return await _context.Transactions
                .Include(t => t.Utilisateur)
                .Where(t => t.Type == type)
                .OrderByDescending(t => t.DateTransaction)
                .ToListAsync();
        }

        public async Task<IEnumerable<Transaction>> GetByDateRangeAsync(DateTime debut, DateTime fin)
        {
            return await _context.Transactions
                .Include(t => t.Utilisateur)
                .Where(t => t.DateTransaction >= debut && t.DateTransaction <= fin)
                .OrderByDescending(t => t.DateTransaction)
                .ToListAsync();
        }
    }
}