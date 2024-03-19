using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backendServer.Models
{
    public class Brand
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long BrandID { get; set; }
        
        [Required]
        public string? BrandName { get; set; }

        [Required]
        public string? CompanyName { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        // Navigation property
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
