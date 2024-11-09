using System.ComponentModel.DataAnnotations;

namespace EcommerceAppV3.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 1)]
        public string FirstName { get; set; } = String.Empty;

        [StringLength(50, MinimumLength = 1)]
        public string LastName { get; set; } = String.Empty;

        [StringLength(50, MinimumLength = 1)]
        public string Company { get; set; } = String.Empty;

        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }

        [RegularExpression(@"^(\+\d{1,2}\s?)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$", ErrorMessage = "Invalid phone format")]
        public string? Phone { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        //----- relationship to Product -----
        public ICollection<Product> Products { get; set; } = [];    //navigation property
    }
}
