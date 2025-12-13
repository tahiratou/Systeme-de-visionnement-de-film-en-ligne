using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VisionFlix.SharedKernel;
using VisionFlix.SharedKernel.Interfaces;

namespace VisionFlix.Core.Entities
{
    [Table("Categories")]
    public class Categorie : BaseEntity, IAggregateRoot
    {

        [Required]
        [MaxLength(100)]
        public string Nom { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Description { get; set; }

        [Required]
        public bool EstActive { get; set; } = true;
    }
}