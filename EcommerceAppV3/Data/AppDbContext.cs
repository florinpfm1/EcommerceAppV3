using EcommerceAppV3.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAppV3.Data
{
    public class AppDbContext : DbContext
    {
        //CTOR
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //PROPERTIES - these are the table names in db
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
    }
}
