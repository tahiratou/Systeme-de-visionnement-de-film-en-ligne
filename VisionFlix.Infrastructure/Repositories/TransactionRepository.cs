using Microsoft.EntityFrameworkCore;
using VisionFlix.Domain.Entities;
using VisionFlix.Domain.Interfaces;
using VisionFlix.Infrastructure.Data;

namespace VisionFlix.Infrastructure.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly VisionFlixDbContext _context;

        public TransactionRepository(VisionFlixDbContext context)
        {
            _context = context;
        }

        public async Task<Transaction?> GetByIdAsync(int id)
        {
            return await _context.Transactions
                .Include(t => t.Utilisateur)
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<IEnumerable<Transaction>> GetAllAsync()
        {
            return await _context.Transactions
                .Include(t => t.Utilisateur)
                .ToListAsync();
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

        public async Task<Transaction> AddAsync(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();
            return transaction;
        }

        public async Task<Transaction> UpdateAsync(Transaction transaction)
        {
            _context.Entry(transaction).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return transaction;
        }

        public async Task DeleteAsync(int id)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction != null)
            {
                _context.Transactions.Remove(transaction);
                await _context.SaveChangesAsync();
            }
        }
    }
}