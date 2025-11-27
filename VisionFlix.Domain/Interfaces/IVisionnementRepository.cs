using VisionFlix.Domain.Entities;

namespace VisionFlix.Domain.Interfaces
{
    public interface IVisionnementRepository
    {
        Task<Visionnement?> GetByIdAsync(int id);
        Task<IEnumerable<Visionnement>> GetByUtilisateurIdAsync(int utilisateurId);
        Task<IEnumerable<Visionnement>> GetByFilmIdAsync(int filmId);
        Task<Visionnement> AddAsync(Visionnement visionnement);
        Task UpdateAsync(Visionnement visionnement);
    }
}