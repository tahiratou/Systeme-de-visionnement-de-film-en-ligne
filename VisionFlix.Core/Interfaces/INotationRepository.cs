using VisionFlix.Core.Entities;
using VisionFlix.SharedKernel.Interfaces;  // ← AJOUTER

namespace VisionFlix.Core.Interfaces
{
    public interface INotationRepository : IAsyncRepository<Notation>, IRepository<Notation> 
    {

        Task<Notation?> GetByUtilisateurAndFilmAsync(int utilisateurId, int filmId);
        Task<IEnumerable<Notation>> GetByFilmIdAsync(int filmId);
    }
}