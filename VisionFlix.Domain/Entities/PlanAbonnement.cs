using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisionFlix.Domain.Entities
{
    [Table("PlansAbonnement")]
    public class PlanAbonnement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nom { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Prix { get; set; }

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        public bool EstActif { get; set; } = true;

        // Navigation property
        public virtual ICollection<Utilisateur> Utilisateurs { get; set; } = new List<Utilisateur>();
    }
}