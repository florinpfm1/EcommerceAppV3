namespace EcommerceAppV3.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public string DeliveryType { get; set; } = String.Empty;
        public string DeliveryAddress { get; set; } = String.Empty;
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        //----- relationship to Order -----
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;     //navigation property
    }
}
