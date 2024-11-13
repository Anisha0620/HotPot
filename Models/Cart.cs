// Models/Cart.cs
namespace HotPot.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserId { get; set; }  // Foreign Key to User
        public decimal TotalAmount { get; set; }
        public User User { get; set; }  // Navigation property
    }
}
