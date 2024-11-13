// Models/CartItem.cs
namespace HotPot.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }  // Foreign Key to Cart
        public int MenuId { get; set; }  // Foreign Key to Menu
        public int Quantity { get; set; }
        public decimal Price { get; set; }  // Price at the time added to cart
        public Cart Cart { get; set; }  // Navigation property
        public Menu Menu { get; set; }  // Navigation property
    }
}

