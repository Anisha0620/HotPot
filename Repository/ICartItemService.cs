// Repository/ICartItemService.cs
using HotPot.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotPot.Repository
{
    public interface ICartItemService
    {
        Task<CartItem> GetCartItemByIdAsync(int id);
        Task<IEnumerable<CartItem>> GetAllCartItemsAsync();
        Task<CartItem> CreateCartItemAsync(CartItem cartItem);
        Task<CartItem> UpdateCartItemAsync(CartItem cartItem);
        Task<bool> DeleteCartItemAsync(int id);
    }
}
