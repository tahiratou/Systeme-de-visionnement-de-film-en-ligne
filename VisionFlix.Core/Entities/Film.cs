using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VisionFlix.SharedKernel;
using VisionFlix.SharedKernel.Interfaces;

namespace VisionFlix.Core.Entities
{
    [Table("Films")]
    public class Film : BaseEntity, IAggregateRoot
    {

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
        [MaxLength(50)]
        public string Langue { get; set; } = "Français";

        [Required]
        public int Duree { get; set; }

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