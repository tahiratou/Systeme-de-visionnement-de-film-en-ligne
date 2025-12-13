using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VisionFlix.SharedKernel;
using VisionFlix.SharedKernel.Interfaces;

namespace VisionFlix.Core.Entities
{
    [Table("PlansAbonnement")]
    public class PlanAbonnement : BaseEntity, IAggregateRoot
    {

        [Required]
        [MaxLength(100)]
        public string Nom { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Prix { get; set; }

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        public bool EstActif { get; set; } = true;

        public virtual ICollection<Utilisateur> Utilisateurs { get; set; } = new List<Utilisateur>();
    }
}