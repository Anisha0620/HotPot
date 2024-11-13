// Models/User.cs
using Microsoft.AspNetCore.Identity;

namespace HotPot.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}

