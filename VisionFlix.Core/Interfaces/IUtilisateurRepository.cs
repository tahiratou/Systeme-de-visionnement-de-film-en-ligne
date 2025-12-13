using VisionFlix.Core.Entities;
using VisionFlix.SharedKernel.Interfaces;  

namespace VisionFlix.Core.Interfaces
{
    public interface IUtilisateurRepository : IAsyncRepository<Utilisateur>, IRepository<Utilisateur>  
    {

        Task<Utilisateur?> GetByEmailAsync(string email);
        Task<Utilisateur?> GetByNomUtilisateurAsync(string nomUtilisateur);
        Task<bool> EmailExistsAsync(string email);
        Task<bool> NomUtilisateurExistsAsync(string nomUtilisateur);
    }
}