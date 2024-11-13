// Repository/IOrderItemService.cs
using HotPot.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotPot.Repository
{
    public interface IOrderItemService
    {
        Task<OrderItem> GetOrderItemByIdAsync(int id);
        Task<IEnumerable<OrderItem>> GetAllOrderItemsAsync();
        Task<OrderItem> CreateOrderItemAsync(OrderItem orderItem);
        Task<OrderItem> UpdateOrderItemAsync(OrderItem orderItem);
        Task<bool> DeleteOrderItemAsync(int id);
    }
}

