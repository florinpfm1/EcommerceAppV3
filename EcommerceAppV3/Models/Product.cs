using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EcommerceAppV3.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(150, MinimumLength = 1)]
        public string Name { get; set; } = String.Empty;
        public string? Description { get; set; }

        [StringLength(50, MinimumLength = 1)]
        public string Category { get; set; } = String.Empty;

        [Precision(18, 2)]
        public decimal Price { get; set; }
        public bool? IsInStock { get; set; }
        public string? PhotoUrl { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public bool? Active { get; set; }

        //----- relationship to Seller -----
        public int SellerId { get; set; }
        public Seller Seller { get; set; } = null!;     //navigation property
        //----- relationship to Order -----
        public ICollection<Order> Orders { get; set; } = [];     //navigation property
    }
}
