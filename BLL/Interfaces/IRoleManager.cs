using BLL.Models;
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IRoleManager
    {
        Task CreateRoleAsync(RoleDto roleDto);

        Task DeleteRoleAsync(string roleName);

        IEnumerable<RoleDto> GetAllRoles();

        Task<Role> GetRoleByName(string roleName);

        Role GetRoleByIdAsync(int id);
    }
}
