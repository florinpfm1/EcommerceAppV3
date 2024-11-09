using System.ComponentModel.DataAnnotations;

namespace EcommerceAppV3.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 1)]
        public string FirstName { get; set; } = String.Empty;

        [StringLength(50, MinimumLength = 1)]
        public string LastName { get; set; } = String.Empty;

        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }

        [RegularExpression(@"^(\+\d{1,2}\s?)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$", ErrorMessage = "Invalid phone format")]
        public string? Phone { get; set; }

        [StringLength(100, MinimumLength = 1)]
        public string Address { get; set; } = String.Empty;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? Birthdate { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        //----- relationship to Payment -----
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();     //navigation property

        //----- relationship to Order -----
        public ICollection<Order> Orders { get; set; } = new List<Order>();     //navigation property
    }
}
