using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backendServer.Data.Users
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CustomerID { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? CompanyName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? CustomerEmailID { get; set; }

        [Required]
        public string? PasswordHash { get; set; }

        [Required]
        public DateOnly DateOfBirth {  get; set; } 

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Contact Person Phone")]
        [DataType(DataType.PhoneNumber)]
        public string? CustomerPhone { get; set; }

        public DateTime CreatedAt { get; set; }

        //One customer can have multiple orders
        public ICollection<Order> Orders { get; set; } = null!;

        //One customer can have multiple customer addresses
        public ICollection<CustomerAddress> customerAddresses { get; set; } = null!;

        //One customer has one cart and one wishlist 
        public Cart Cart { get; set; } = null!;
        public Wishlist Wishlist { get; set; } = null!;
    } 
}
