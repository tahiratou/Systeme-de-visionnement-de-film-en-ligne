using VisionFlix.SharedKernel;
using VisionFlix.SharedKernel.Interfaces;

namespace VisionFlix.Core.Entities
{
    public class Utilisateur : BaseEntity, IAggregateRoot
    {
        public string NomUtilisateur { get; set; } = string.Empty;
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telephone { get; set; } = string.Empty;
        public string Adresse { get; set; } = string.Empty;
        public string MotDePasse { get; set; } = string.Empty;

        public decimal Solde { get; set; } = 0;

        public bool EstAdministrateur { get; set; } = false;

        public bool EstAbonne { get; set; } = false;
        public int? PlanAbonnementId { get; set; }

        public string Langue { get; set; } = "fr"; 
        public bool NotificationsActivees { get; set; } = true;


        public DateTime? DateExpirationAbonnement { get; set; }

        public DateTime DateInscription { get; set; } = DateTime.Now;
        public DateTime? DerniereConnexion { get; set; }

        public PlanAbonnement? PlanAbonnement { get; set; }
        public ICollection<Achat> Achats { get; set; } = new List<Achat>();
        public ICollection<Visionnement> Visionnements { get; set; } = new List<Visionnement>();
        public ICollection<Notation> Notations { get; set; } = new List<Notation>();
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();


        public string NomComplet => $"{Prenom} {Nom}";

        
        public bool AbonnementActif => EstAbonne &&
                                       DateExpirationAbonnement.HasValue &&
                                       DateExpirationAbonnement.Value > DateTime.Now;

        public string PlanActuel => PlanAbonnement?.Nom ?? "Aucun";

        
        public Utilisateur()
        {
        }

        
        public Utilisateur(int id, string nom, string prenom, string email)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
        }

        
        public override string ToString()
        {
            string role = EstAdministrateur ? "[ADMIN]" : "[USER]";
            return $"{role} {NomComplet} ({Email})";
        }

        
        public bool AFilmAchete(int filmId)
        {
            return Achats.Any(a => a.FilmId == filmId);
        }

        public bool AFilmVisionne(int filmId)
        {
            return Visionnements.Any(v => v.FilmId == filmId);
        }

        public int? GetNotationFilm(int filmId)
        {
            var notation = Notations.FirstOrDefault(n => n.FilmId == filmId);
            return notation?.Note;
        }
    }
}