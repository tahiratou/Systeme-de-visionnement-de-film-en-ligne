namespace VisionFlix.Domain.Entities
{
    public class Utilisateur
    {
        // ===== PROPRIÉTÉS DE BASE =====
        public int Id { get; set; }
        public string NomUtilisateur { get; set; } = string.Empty;
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telephone { get; set; } = string.Empty;
        public string Adresse { get; set; } = string.Empty;
        public string MotDePasse { get; set; } = string.Empty;

        // ✅ SOLDE (decimal pour correspondre à la BD)
        public decimal Solde { get; set; } = 0;

        // ✅ ADMINISTRATION (EstAdministrateur pour correspondre à la BD)
        public bool EstAdministrateur { get; set; } = false;

        // ===== ABONNEMENT =====
        public bool EstAbonne { get; set; } = false;
        public int? PlanAbonnementId { get; set; }
        public DateTime? DateExpirationAbonnement { get; set; }

        // ===== DATES =====
        public DateTime DateInscription { get; set; } = DateTime.Now;
        public DateTime? DerniereConnexion { get; set; }

        // ===== RELATIONS NAVIGATION =====
        public PlanAbonnement? PlanAbonnement { get; set; }
        public ICollection<Achat> Achats { get; set; } = new List<Achat>();
        public ICollection<Visionnement> Visionnements { get; set; } = new List<Visionnement>();
        public ICollection<Notation> Notations { get; set; } = new List<Notation>();
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

        // ===== PROPRIÉTÉS CALCULÉES =====

        /// <summary>
        /// Retourne le nom complet de l'utilisateur
        /// </summary>
        public string NomComplet => $"{Prenom} {Nom}";

        /// <summary>
        /// Vérifie si l'abonnement est actif
        /// </summary>
        public bool AbonnementActif => EstAbonne &&
                                       DateExpirationAbonnement.HasValue &&
                                       DateExpirationAbonnement.Value > DateTime.Now;

        /// <summary>
        /// Retourne le nom du plan actuel
        /// </summary>
        public string PlanActuel => PlanAbonnement?.Nom ?? "Aucun";

        // ===== CONSTRUCTEURS =====

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Utilisateur()
        {
        }

        /// <summary>
        /// Constructeur avec paramètres de base
        /// </summary>
        public Utilisateur(int id, string nom, string prenom, string email)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
        }

        // ===== MÉTHODES =====

        /// <summary>
        /// Retourne une représentation textuelle de l'utilisateur
        /// </summary>
        public override string ToString()
        {
            string role = EstAdministrateur ? "[ADMIN]" : "[USER]";
            return $"{role} {NomComplet} ({Email})";
        }

        /// <summary>
        /// Vérifie si l'utilisateur a acheté un film
        /// </summary>
        public bool AFilmAchete(int filmId)
        {
            return Achats.Any(a => a.FilmId == filmId);
        }

        /// <summary>
        /// Vérifie si l'utilisateur a visionné un film
        /// </summary>
        public bool AFilmVisionne(int filmId)
        {
            return Visionnements.Any(v => v.FilmId == filmId);
        }

        /// <summary>
        /// Obtient la notation donnée à un film
        /// </summary>
        public int? GetNotationFilm(int filmId)
        {
            var notation = Notations.FirstOrDefault(n => n.FilmId == filmId);
            return notation?.Note;
        }
    }
}