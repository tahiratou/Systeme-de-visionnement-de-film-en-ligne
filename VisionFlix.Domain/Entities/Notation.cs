using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisionFlix.Domain.Entities
{
    [Table("Notations")]
    public class Notation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int UtilisateurId { get; set; }

        [Required]
        public int FilmId { get; set; }

        [Required]
        [Range(1, 5)]
        public int Note { get; set; }

        [MaxLength(1000)]
        public string? Commentaire { get; set; }

        [Required]
        public DateTime DateNotation { get; set; } = DateTime.Now;

        // Navigation properties
        [ForeignKey("UtilisateurId")]
        public virtual Utilisateur Utilisateur { get; set; } = null!;

        [ForeignKey("FilmId")]
        public virtual Film Film { get; set; } = null!;
    }
}