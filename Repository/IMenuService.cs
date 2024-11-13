// Repository/IMenuService.cs
using HotPot.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotPot.Repository
{
    public interface IMenuService
    {
        Task<Menu> GetMenuByIdAsync(int id);
        Task<IEnumerable<Menu>> GetAllMenusAsync();
        Task<Menu> CreateMenuAsync(Menu menu);
        Task<Menu> UpdateMenuAsync(Menu menu);
        Task<bool> DeleteMenuAsync(int id);
    }
}

