using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backendServer.Models
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CartId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        [ForeignKey("Customer")]
        public long CustomerID { get; set; }


        //one wishlist belonging to one customer only
        public Customer Customer { get; set; } = null!;

        //wishlist containing multiple wishlist items
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
