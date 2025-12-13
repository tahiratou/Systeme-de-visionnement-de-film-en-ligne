using VisionFlix.Core.Entities;
using VisionFlix.SharedKernel.Interfaces;

namespace VisionFlix.Core.Interfaces
{
    public interface IAchatRepository : IAsyncRepository<Achat>, IRepository<Achat>
    {
        Task<IEnumerable<Achat>> GetByUtilisateurIdAsync(int utilisateurId);
        Task<Achat?> GetByUtilisateurAndFilmAsync(int utilisateurId, int filmId);
        Task<bool> UtilisateurHasAcheteFilmAsync(int utilisateurId, int filmId);
    }
}