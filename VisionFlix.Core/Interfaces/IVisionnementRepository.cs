using VisionFlix.Core.Entities;
using VisionFlix.SharedKernel.Interfaces;  

namespace VisionFlix.Core.Interfaces
{
    public interface IVisionnementRepository : IAsyncRepository<Visionnement>, IRepository<Visionnement>  
    {

        Task<IEnumerable<Visionnement>> GetByUtilisateurIdAsync(int utilisateurId);
        Task<IEnumerable<Visionnement>> GetByFilmIdAsync(int filmId);
    }
}