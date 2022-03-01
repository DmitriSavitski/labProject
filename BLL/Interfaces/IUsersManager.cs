using BLL.Models;
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUsersManager
    {
        Task CreateUserAsync(UsersDto userDto);

        Task DeleteUserAsync(string login);

        Task UpdateUserAsync(UsersDto userDto);

        IEnumerable<Users> GetAllUsers();

        Task<UsersDto> GetUserByLogin(string login);
    }
}
