using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backendServer.Models
{
    public class CartItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CartItemId { get; set; }

        [Required]
        public int CartItemQuantity { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        [ForeignKey("ProductItem")]
        public long ProductItemID { get; set; }

        [Required]
        [ForeignKey("Cart")]
        public long CartID { get; set; }

        //One wishlist item is one product
        public ProductItem ProductItem { get; set; } = null!;

        //one wishlist item belonging to one wishlist only
        public Cart Cart { get; set; } = null!;
    }
}
