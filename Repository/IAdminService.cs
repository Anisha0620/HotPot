// Repository/IAdminService.cs
using HotPot.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotPot.Repository
{
    public interface IAdminService
    {
        Task<Admin> GetAdminByIdAsync(int id);
        Task<IEnumerable<Admin>> GetAllAdminsAsync();
        Task<Admin> CreateAdminAsync(Admin admin);
        Task<Admin> UpdateAdminAsync(Admin admin);
        Task<bool> DeleteAdminAsync(int id);
    }
}

