using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VisionFlix.SharedKernel;
using VisionFlix.SharedKernel.Interfaces;

namespace VisionFlix.Core.Entities
{
    [Table("Achats")]
    public class Achat : BaseEntity, IAggregateRoot
    {

        [Required]
        public int UtilisateurId { get; set; }

        [Required]
        public int FilmId { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal PrixAchat { get; set; }

        [Required]
        public DateTime DateAchat { get; set; } = DateTime.Now;

        [ForeignKey("UtilisateurId")]
        public virtual Utilisateur Utilisateur { get; set; } = null!;

        [ForeignKey("FilmId")]
        public virtual Film Film { get; set; } = null!;
    }
}