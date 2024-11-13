// Models/OrderItem.cs
namespace HotPot.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; } // Foreign Key to Order
        public int MenuId { get; set; }  // Foreign Key to Menu
        public int Quantity { get; set; }
        public decimal Price { get; set; } // Price at the time of order
        public Order Order { get; set; }  // Navigation property
        public Menu Menu { get; set; }    // Navigation property
    }
}
