using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Transactions;

namespace VisionFlix.Domain.Entities
{
    [Table("Utilisateurs")]
    public class Utilisateur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nom { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string NomUtilisateur { get; set; } = string.Empty; 
        [Required]
        [MaxLength(100)]
        public string Prenom { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string MotDePasse { get; set; } = string.Empty; 

        [MaxLength(20)]
        public string? Telephone { get; set; }

        [MaxLength(500)]
        public string? Adresse { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Solde { get; set; } = 0;

        [Required]
        public bool EstAdministrateur { get; set; } = false;

        [Required]
        public bool EstAbonne { get; set; } = false;

        public DateTime? DateExpirationAbonnement { get; set; }

        public int? PlanAbonnementId { get; set; }

        public DateTime DateInscription { get; set; } = DateTime.Now;

        public DateTime? DerniereConnexion { get; set; }

        // Navigation properties
        [ForeignKey("PlanAbonnementId")]
        public virtual PlanAbonnement? PlanAbonnement { get; set; }

        public virtual ICollection<Achat>? Achats { get; set; }
        public virtual ICollection<Visionnement>? Visionnements { get; set; }
        public virtual ICollection<Notation>? Notations { get; set; }
        public virtual ICollection<Transaction>? Transactions { get; set; }
    }
}