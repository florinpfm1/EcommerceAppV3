using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EcommerceAppV3.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string OrderStatus { get; set; } = String.Empty;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? DateOfOrder { get; set; }

        [Precision(18, 2)]
        public decimal? TotalPrice { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;


        //----- relationship to Delivery -----
        public Delivery? Delivery { get; set; }     //navigation property

        //----- relationship to Product -----
        public ICollection<Product> Products { get; set; } = [];     //navigation property

        //----- relationship to Customer -----
        public int? CustomerId { get; set; } //this FK is set to nullable to not have error cycles or multiple cascade paths when DELETE CASCADE is enabled in db tables
        public Customer Customer { get; set; } = null!;     //navigation property

        //----- relationship to Payments -----
        public int? PaymentId { get; set; } //this FK is set to nullable to not have error cycles or multiple cascade paths when DELETE CASCADE is enabled in db tables
        public Payment Payment { get; set; } = null!;     //navigation property
    }
}
