using System.ComponentModel.DataAnnotations;

namespace EcommerceAppV3.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string PaymentType { get; set; } = String.Empty;
        public string CardIssuer { get; set; } = String.Empty;
        public string CardNumber { get; set; } = String.Empty;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime CardExpiration { get; set; }

        public string CardCVV { get; set; } = String.Empty;
        public string? Currency { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        //----- relationship to Customer -----
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;     //navigation property

        //----- relationship to Order -----
        public ICollection<Order> Orders { get; set; } = new List<Order>(); //navigation property
    }
}
