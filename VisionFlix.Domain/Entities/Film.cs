using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisionFlix.Domain.Entities
{
    [Table("Films")]
    public class Film
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Titre { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string Realisateur { get; set; } = string.Empty;

        [Required]
        public int Annee { get; set; }

        [Required]
        [Range(0.0, 5.0)]
        public double Note { get; set; }

        [Required]
        public int Duree { get; set; } // en minutes

        [Required]
        [MaxLength(50)]
        public string Genre { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? ImageUrl { get; set; }
        [MaxLength(2000)]
        public string? Synopsis { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Prix { get; set; }

        [Required]
        public bool EstDisponible { get; set; } = true;

        public DateTime DateAjout { get; set; } = DateTime.Now;

        public virtual ICollection<Achat>? Achats { get; set; }
        public virtual ICollection<Visionnement>? Visionnements { get; set; }
        public virtual ICollection<Notation>? Notations { get; set; }
    }
}