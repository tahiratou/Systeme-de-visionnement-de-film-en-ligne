using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VisionFlix.SharedKernel;
using VisionFlix.SharedKernel.Interfaces;

namespace VisionFlix.Core.Entities
{
    [Table("Visionnements")]
    public class Visionnement : BaseEntity, IAggregateRoot
    {

        [Required]
        public int UtilisateurId { get; set; }

        [Required]
        public int FilmId { get; set; }

        [Required]
        public DateTime DateVisionnement { get; set; } = DateTime.Now;

        public int? ProgressionEnSecondes { get; set; }

        public bool EstComplete { get; set; } = false;

        [ForeignKey("UtilisateurId")]
        public virtual Utilisateur Utilisateur { get; set; } = null!;

        [ForeignKey("FilmId")]
        public virtual Film Film { get; set; } = null!;
    }
}