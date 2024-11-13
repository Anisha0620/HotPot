// Repository/ICartService.cs
using HotPot.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotPot.Repository
{
    public interface ICartService
    {
        Task<Cart> GetCartByIdAsync(int id);
        Task<IEnumerable<Cart>> GetAllCartsAsync();
        Task<Cart> CreateCartAsync(Cart cart);
        Task<Cart> UpdateCartAsync(Cart cart);
        Task<bool> DeleteCartAsync(int id);
    }
}

