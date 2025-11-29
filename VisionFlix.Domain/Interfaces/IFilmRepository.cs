using VisionFlix.Domain.Entities;

namespace VisionFlix.Domain.Interfaces
{
    public interface IFilmRepository
    {
        Task<Film?> GetByIdAsync(int id);
        Task<IEnumerable<Film>> GetAllAsync();
        Task<IEnumerable<Film>> SearchAsync(string? titre, string? genre, int? annee, double? noteMinimum);

        Task<Film> AddAsync(Film film);
        Task UpdateAsync(Film film);
        Task DeleteAsync(int id);

        Task<bool> ExistsAsync(int id);
    }
}