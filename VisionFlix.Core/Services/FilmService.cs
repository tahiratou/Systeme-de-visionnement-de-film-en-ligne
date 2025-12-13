using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;

namespace VisionFlix.Core.Services
{
    public class FilmService : IFilmService
    {
        private readonly IFilmRepository _filmRepository;

        public FilmService(IFilmRepository filmRepository)
        {
            _filmRepository = filmRepository;
        }

        public async Task<Film?> GetFilmByIdAsync(int id)
        {
            return await _filmRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Film>> GetAllFilmsAsync()
        {
            // ✅ CHANGEMENT: GetAllAsync() → ListAllAsync()
            return await _filmRepository.ListAllAsync();
        }

        public async Task<IEnumerable<Film>> SearchFilmsAsync(string? titre, string? genre, int? annee, double? noteMinimum)
        {
            return await _filmRepository.SearchAsync(titre, genre, annee, noteMinimum);
        }

        public async Task<Film> AddFilmAsync(Film film)
        {
            if (string.IsNullOrWhiteSpace(film.Titre))
                throw new ArgumentException("Le titre du film est requis.");

            if (film.Annee < 1900 || film.Annee > DateTime.Now.Year + 5)
                throw new ArgumentException("L'année du film n'est pas valide.");

            if (film.Prix < 0)
                throw new ArgumentException("Le prix ne peut pas être négatif.");

            film.DateAjout = DateTime.Now;
            film.EstDisponible = true;

            return await _filmRepository.AddAsync(film);
        }

        public async Task UpdateFilmAsync(Film film)
        {
            if (string.IsNullOrWhiteSpace(film.Titre))
                throw new ArgumentException("Le titre du film est requis.");

            var existingFilm = await _filmRepository.GetByIdAsync(film.Id);
            if (existingFilm == null)
                throw new InvalidOperationException("Film introuvable.");

            await _filmRepository.UpdateAsync(film);
        }

        public async Task DeleteFilmAsync(int id)
        {
            var film = await _filmRepository.GetByIdAsync(id);
            if (film == null)
                throw new InvalidOperationException("Film introuvable.");

            film.EstDisponible = false;
            await _filmRepository.UpdateAsync(film);
        }

        public async Task<bool> FilmExistsAsync(int id)
        {
            return await _filmRepository.ExistsAsync(id);
        }
    }
}
