using VisionFlix.Core.Entities;
using VisionFlix.SharedKernel.Interfaces;

namespace VisionFlix.Core.Interfaces
{
    public interface IFilmRepository: IAsyncRepository<Film>, IRepository<Film>
    {
        Task<IEnumerable<Film>> SearchAsync(string? titre, string? genre, int? annee, double? noteMinimum);

        Task<bool> ExistsAsync(int id);


       
    }
}