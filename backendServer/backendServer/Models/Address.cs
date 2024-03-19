using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backendServer.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AddressId { get; set; }

        public string? AddressName { get; set; }

        [Required]
        public string? AddressContactName { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Contact Person Phone")]
        [DataType(DataType.PhoneNumber)]
        public string? MobileNumber { get; set;}

        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? EmailID { get; set; }

        [Required]
        public string? AddressLine1 { get; set; }

        [Required]
        public string? AddressLine2 { get; set; }

        public string? Landmark {  get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public string? State { get; set; }

        [Required]
        public string? PostalCode { get; set;}

        [Required] 
        public string? Country { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
    }

    public class CustomerAddress
    {
        [Required]
        public long CustomerAddressId { get; set; }

        [Required]
        [ForeignKey("Address")]
        public long AddressId { get; set; }

        [Required]
        [ForeignKey("Customer")]
        public long CustomerId { get; set; }

        public Customer Customer { get; set; } = null!;
        public Address Address { get; set; } = null!;
    }

    public class SellerAddress
    {
        [Required]
        public long SellerAddressId { get; set; }

        [Required]
        [ForeignKey("Address")]
        public long AddressId { get; set; }

        [Required]
        [ForeignKey("Seller")]
        public long SellerId { get; set; }

        public Seller Seller { get; set; } = null!;
        public Address Address { get; set; } = null!;
    }

    public class ShippingAddress
    {
        [Required]
        public long ShippingAddressId { get; set; }

        [Required]
        [ForeignKey("Address")]
        public long AddressId { get; set; }

        [Required]
        [ForeignKey("Seller")]
        public long SellerId { get; set; }

        [Required]
        [ForeignKey("Customer")]
        public long CustomerId { get; set; }

        public Customer Customer { get; set; } = null!;
        public Seller Seller { get; set; } = null!;
        public Address Address { get; set; } = null!;
    }

    public class BillingAddress
    {
        [Required]
        public long BillingAddressId { get; set; }

        [Required]
        [ForeignKey("Address")]
        public long AddressId { get; set; }

        [Required]
        [ForeignKey("Seller")]
        public long SellerId { get; set; }

        [Required]
        [ForeignKey("Customer")]
        public long CustomerId { get; set; }

        public Customer Customer { get; set; } = null!;
        public Seller Seller { get; set; } = null!;
        public Address Address { get; set; } = null!;
    }

}
