using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backendServer.Models
{
    public class Order
    {
        [Key]
        [Required]
        public long OrderID { get; set; }

        [Required]
        public long OrderFinalAmount { get; set; }

        [Required]
        [Column(TypeName = "jsonb")]
        public string? TrackingInformation { get; set; }

        [Required]
        public DateOnly EstimatedDeliveryDate { get; set; }

        [Required]
        public string? OrderStatus { get; set; }

        [Required]
        public string? ShippingMethod { get; set; }

        [Required]
        public string? ShippingCost { get; set; }

        public string? PromoCode { get; set; }

        [Required]
        public DateTime OrderDateTime { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        [ForeignKey("ShippingAddress")]
        public long ShippingAddressID { get; set; }

        [Required]
        [ForeignKey("BillingAddress")]
        public long BillingAddressID { get; set; }


        [Required]
        [ForeignKey("Customer")]
        public long CustomerId { get; set; }

        [Required]
        [ForeignKey("Seller")]
        public long SellerId { get; set; }

        //order having one billing address and one shipping address
        public ShippingAddress ShippingAddress { get; set; } = null!;
        public BillingAddress BillingAddress { get; set; } = null!;

        //one order belonging to one customer
        public Customer Customer { get; set; } = null!;

        //one order belonging to one seller
        public Seller Seller{ get; set; } = null!;

        //one order containing multiple order items
        public ICollection<OrderItem> orderItems { get; set; } = null!;
    }
}
