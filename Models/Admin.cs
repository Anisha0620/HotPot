// Models/Admin.cs
namespace HotPot.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string UserId { get; set; }  // Foreign key to User
        public string Role { get; set; }  // e.g., "SuperAdmin", "Manager"

        public User User { get; set; }  // Navigation property to the User model
    }
}
