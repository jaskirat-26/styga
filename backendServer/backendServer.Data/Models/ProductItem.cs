using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backendServer.Models
{
    public class ProductItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ProductItemID { get; set; }

        [Required]
        public float ProductDiscount { get; set; }

        [Required]
        public string? ProductPostalCode { get; set; }

        [Required]
        [Column(TypeName = "jsonb")]
        public string? ProductInventory { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        // Product Foreign Key
        [Required]
        [ForeignKey("Product")]
        public long ProductID { get; set; }

        // Seller Foreign Key
        [Required]
        [ForeignKey("Seller")]
        public long SellerID { get; set; }

        //One product Item belonging to one seller
        public Seller Seller{ get; set; } = null!;

        //One product Item being one product
        public Product Product{ get; set; } = null!;
    }
}
