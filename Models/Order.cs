// Models/Order.cs
namespace HotPot.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; } // Foreign Key to User
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }  // e.g., Pending, Delivered
        public User User { get; set; }  // Navigation property
    }
}

