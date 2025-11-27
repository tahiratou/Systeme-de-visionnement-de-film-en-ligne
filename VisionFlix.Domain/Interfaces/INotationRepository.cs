using VisionFlix.Domain.Entities;

namespace VisionFlix.Domain.Interfaces
{
    public interface INotationRepository
    {
        Task<Notation?> GetByIdAsync(int id);
        Task<Notation?> GetByUtilisateurAndFilmAsync(int utilisateurId, int filmId);
        Task<IEnumerable<Notation>> GetByFilmIdAsync(int filmId);
        Task<Notation> AddAsync(Notation notation);
        Task UpdateAsync(Notation notation);
        Task DeleteAsync(int id);
    }
}