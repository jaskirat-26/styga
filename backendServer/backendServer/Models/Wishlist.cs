using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backendServer.Models
{
    public class Wishlist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long WishlistId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        [ForeignKey("Customer")]
        public long CustomerID { get; set; }


        //one wishlist belonging to one customer only
        public Customer Customer { get; set; } = null!;

        //wishlist containing multiple wishlist items
        public ICollection<WishlistItem> wishlistItems { get; set; } = new List<WishlistItem>();
    }
}
