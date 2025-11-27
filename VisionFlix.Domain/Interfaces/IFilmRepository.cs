using VisionFlix.Domain.Entities;

namespace VisionFlix.Domain.Interfaces
{
    public interface IFilmRepository
    {
        // Lecture
        Task<Film?> GetByIdAsync(int id);
        Task<IEnumerable<Film>> GetAllAsync();
        Task<IEnumerable<Film>> SearchAsync(string? titre, string? genre, int? annee, double? noteMinimum);

        // Écriture
        Task<Film> AddAsync(Film film);
        Task UpdateAsync(Film film);
        Task DeleteAsync(int id);

        // Vérifications
        Task<bool> ExistsAsync(int id);
    }
}