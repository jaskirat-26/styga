using backendServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace PostgreSQL.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<CustomerAddress> CustomerAddress { get; set; }
        public DbSet<ShippingAddress> ShippingAddress { get; set; }
        public DbSet<SellerAddress> SellerAddress { get; set;}
        public DbSet<BillingAddress> BillingAddress { get; set; }
        
        public DbSet<Brand> Brand { get; set; }

        public DbSet<Cart> Cart { get; set; }
        
        public DbSet<CartItem> CartItem { get; set; }

        public DbSet<Customer> Customer { get; set; }
        
        public DbSet<OptionsGrid> OptionsGrid { get; set; }
        
        public DbSet<Order> Order { get; set; }
        
        public DbSet<OrderItem> OrderItem { get; set; }
        
        public DbSet<Product> Product { get; set; }
        
        public DbSet<ProductCategory> Category { get; set; }
        
        public DbSet<ProductColor> ProductColor { get; set; }
        
        public DbSet<ProductImageSet> ProductImageSet { get; set; }
        
        public DbSet<ProductItem> ProductItems { get; set; }
        
        public DbSet<Seller> Seller { get; set; }
        
        public DbSet<Wishlist> Wishlist { get; set; }
        
        public DbSet<WishlistItem> WishlistItem { get; set; }
    }
}