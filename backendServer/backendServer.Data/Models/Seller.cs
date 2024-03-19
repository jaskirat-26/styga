using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backendServer.Models
{
    public class Seller
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SellerID { get; set; }

        [Required]
        public string? ContactPersonName { get; set; }

        [Required]
        public string? CompanyName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? ContactPersonEmailID { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? CompanyEmailID { get; set; }

        [Required]
        public string? PasswordHash { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Contact Person Phone")]
        [DataType(DataType.PhoneNumber)]
        public string? ContactPersonPhone { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        //One seller can have multiple Seller Addresses
        public ICollection<SellerAddress> sellerAddress { get; set; } = null!;

        //One seller can output multiple orders
        public ICollection<Order> orders { get; set; } = null!;

        //One seller selling multiple product items
        public ICollection<ProductItem> ProductItems { get; set; } = null!;
    }
}
