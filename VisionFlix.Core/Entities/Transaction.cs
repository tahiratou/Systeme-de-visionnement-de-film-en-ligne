using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VisionFlix.SharedKernel;
using VisionFlix.SharedKernel.Interfaces;

namespace VisionFlix.Core.Entities
{
    [Table("Transactions")]
    public class Transaction : BaseEntity, IAggregateRoot
    {


        [Required]
        public int UtilisateurId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Montant { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [Required]
        public DateTime DateTransaction { get; set; } = DateTime.Now;

        [ForeignKey("UtilisateurId")]
        public virtual Utilisateur Utilisateur { get; set; } = null!;
    }
}