using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backendServer.Models
{
    public class ProductCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ProductCategoryID { get; set; }

        [Required]
        public string? ProductCategoryName { get; set; }

        //Product Category being referenced by other product categories
        public long? ParentProductCategoryID { get; set; }
        public ProductCategory ParentProductCategory { get; set; } = null!;
        public ICollection<ProductCategory> ChildProductCategories { get; set; } = new List<ProductCategory>();

        public DateTime CreatedAt { get; set; }

        //One Product Category can have multiple Products
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
