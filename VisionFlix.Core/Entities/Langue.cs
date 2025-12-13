using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VisionFlix.SharedKernel;
using VisionFlix.SharedKernel.Interfaces;

namespace VisionFlix.Core.Entities
{
    [Table("Langues")]
    public class Langue : BaseEntity, IAggregateRoot
    {

        [Required]
        [MaxLength(100)]
        public string Nom { get; set; } = string.Empty;

        [Required]
        [MaxLength(10)]
        public string Code { get; set; } = string.Empty;

        [Required]
        public bool EstActive { get; set; } = true;
    }
}