using VisionFlix.Core.Entities;

namespace VisionFlix.Core.Interfaces
{
    public interface IUtilisateurService
    {
        Task<Utilisateur?> GetUtilisateurByIdAsync(int id);
        Task<Utilisateur?> GetUtilisateurByEmailAsync(string email);
        Task<Utilisateur?> GetUtilisateurByNomUtilisateurAsync(string nomUtilisateur);
        Task<IEnumerable<Utilisateur>> GetAllUtilisateursAsync();

        Task<Utilisateur> CreateUtilisateurAsync(Utilisateur utilisateur);

        Task UpdateUtilisateurAsync(Utilisateur utilisateur);

        Task DeleteUtilisateurAsync(int id);

        Task<bool> EmailExistsAsync(string email);
        Task<bool> NomUtilisateurExistsAsync(string nomUtilisateur);

        Task AjouterSoldeAsync(int utilisateurId, decimal montant);
        Task RetirerSoldeAsync(int utilisateurId, decimal montant);

        Task AbonnerAsync(int utilisateurId, int planAbonnementId);
        Task DesabonnerAsync(int utilisateurId);
        Task<bool> VerifierAbonnementActifAsync(int utilisateurId);
    }
}