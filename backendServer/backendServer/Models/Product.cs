using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backendServer.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ProductID { get; set; }

        [Required]
        public string? ProductName { get; set; }

        [Required]
        [Column(TypeName = "jsonb")]
        public string ProductDescription { get; set; } = string.Empty;

        [Required]
        public float ProductPrice { get; set; }

        public string? ProductThumbnailLocation { get; set; }


        [Required]
        [Column(TypeName = "jsonb")]
        public string AboutTheProduct { get; set; } = string.Empty;

        // Brand Foreign Key
        [ForeignKey("Brand")]
        public long BrandID { get; set; }
        public Brand Brand { get; set; } = null!;

        // Option Grid Foreign Key
        [ForeignKey("OptionsGrid")]
        public long OptionGridID { get; set; }
        public OptionsGrid OptionsGrid { get; set; } = null!;

        // Product Category Foreign Key
        [ForeignKey("ProductCategory")]
        public long ProductCategoryID { get; set; }
        public ProductCategory productCategory { get; set; } = null!;

        // Product Category Foreign Key
        [ForeignKey("ProductColor")]
        public long ProductColorID { get; set; }
        public ProductColor productColor { get; set; } = null!;

        [Required]
        public DateTime CreatedAt { get; set; }

    }
}
