using VisionFlix.Domain.Entities;

namespace VisionFlix.Application.Interfaces
{
    public interface IUtilisateurService
    {
        Task<Utilisateur?> GetUtilisateurByIdAsync(int id);
        Task<Utilisateur?> GetUtilisateurByEmailAsync(string email);
        Task<Utilisateur> CreateUtilisateurAsync(Utilisateur utilisateur);
        Task UpdateUtilisateurAsync(Utilisateur utilisateur);
        Task<bool> AcheterFilmAsync(int utilisateurId, int filmId, decimal prixFilm);
        Task<IEnumerable<Achat>> GetAchatsUtilisateurAsync(int utilisateurId);
        Task<bool> UtilisateurPossedeFilmAsync(int utilisateurId, int filmId);
        Task SouscrireAbonnementAsync(int utilisateurId, int planId, decimal prix);
        Task<bool> EmailExistsAsync(string email);
    }
}
