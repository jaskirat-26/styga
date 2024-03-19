using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backendServer.Models
{
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OrderItemId { get; set; }

        [Required]
        public int OrderItemQuantity { get; set; }

        [Required]
        public float OrderItemBasePrice { get; set; }

        public float OrderItemDiscount { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        [ForeignKey("ProductItem")]
        public long ProductItemID { get; set; }

        [Required]
        [ForeignKey("Order")]
        public long OrderID { get; set; }

        //One wishlist item is one product
        public ProductItem ProductItem { get; set; } = null!;

        //one wishlist item belonging to one wishlist only
        public Order Order { get; set; } = null!;
    }
}
