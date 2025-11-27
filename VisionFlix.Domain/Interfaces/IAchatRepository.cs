using VisionFlix.Domain.Entities;

namespace VisionFlix.Domain.Interfaces
{
    public interface IAchatRepository
    {
        Task<Achat?> GetByIdAsync(int id);
        Task<IEnumerable<Achat>> GetByUtilisateurIdAsync(int utilisateurId);
        Task<Achat?> GetByUtilisateurAndFilmAsync(int utilisateurId, int filmId);
        Task<Achat> AddAsync(Achat achat);
        Task<bool> UtilisateurHasAcheteFilmAsync(int utilisateurId, int filmId);
    }
}