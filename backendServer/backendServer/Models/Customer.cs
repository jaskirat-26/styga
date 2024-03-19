using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backendServer.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CustomerID { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set;}

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? EmailID { get; set; }

        [Required]
        public string? PasswordHash { get; set; }

        [Required]
        public DateOnly DateOfBirth { get; set; }

        [Required]
        public string? MobileNumber { get; set; }

        [Required]
        public DateTime CreatedAt { get; set;}

        public ICollection<Order> Orders { get; set; } = null!;

        public ICollection<Address> Addresses { get; set; } = null!;

        public Cart Cart { get; set; } = null!;

        public Wishlist Wishlist { get; set; } = null!;

    }
}
