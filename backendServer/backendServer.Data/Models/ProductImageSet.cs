using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backendServer.Models
{
    public class ProductImageSet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ProductImageSetID { get; set; }

        [Required]
        public string? ImageSetDirectory { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        [ForeignKey("Product")]
        public long ProductID { get; set; }

        // Navigation property
        public Product Products { get; set; } = null!;
    }
}
