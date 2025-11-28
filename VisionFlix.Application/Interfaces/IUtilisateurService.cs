using VisionFlix.Domain.Entities;

namespace VisionFlix.Application.Interfaces
{
    public interface IUtilisateurService
    {
        // ===== RÉCUPÉRATION =====
        Task<Utilisateur?> GetUtilisateurByIdAsync(int id);
        Task<Utilisateur?> GetUtilisateurByEmailAsync(string email);
        Task<Utilisateur?> GetUtilisateurByNomUtilisateurAsync(string nomUtilisateur);
        Task<IEnumerable<Utilisateur>> GetAllUtilisateursAsync();

        // ===== CRÉATION =====
        Task<Utilisateur> CreateUtilisateurAsync(Utilisateur utilisateur);

        // ===== MISE À JOUR =====
        Task UpdateUtilisateurAsync(Utilisateur utilisateur);

        // ===== SUPPRESSION =====
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