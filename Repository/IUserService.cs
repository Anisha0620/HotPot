// IUserService.cs
using HotPot.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotPot.Repository
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(string id); // id is a string
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> CreateUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task<bool> DeleteUserAsync(string id); // id is a string
    }
}

