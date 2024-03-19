using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backendServer.Models
{
    public class WishlistItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long WishlistItemId { get; set; }

        [Required]
        public int WishlistItemQuantity { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        [ForeignKey("Product")]
        public long ProductID { get; set; }

        [Required]
        [ForeignKey("Wishlist")]
        public long WishlistID { get; set; }

        //One wishlist item is one product
        public Product Product { get; set; } = null!;

        //one wishlist item belonging to one wishlist only
        public Wishlist Wishlist{ get; set; } = null!;
        
    }
}
