using VisionFlix.Core.Entities;

namespace VisionFlix.Core.Interfaces
{
    public interface IFilmService
    {
        Task<Film?> GetFilmByIdAsync(int id);
        Task<IEnumerable<Film>> GetAllFilmsAsync();
        Task<IEnumerable<Film>> SearchFilmsAsync(string? titre, string? genre, int? annee, double? noteMinimum);
        Task<Film> AddFilmAsync(Film film);
        Task UpdateFilmAsync(Film film);
        Task DeleteFilmAsync(int id);
        Task<bool> FilmExistsAsync(int id);

    }
}