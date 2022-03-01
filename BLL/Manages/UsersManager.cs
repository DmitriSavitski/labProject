using BLL.Interfaces;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;
using System.Linq;

namespace BLL.Manages
{
    public class UsersManager : IUsersManager
    {
        private readonly IRepositoryManager<Users> _repositoryManager;
        private readonly IRepositoryManager<Role> _roleManager;

        public UsersManager(IRepositoryManager<Users> repositoryManager, IRepositoryManager<Role> roleManager)
		{
            _repositoryManager = repositoryManager;
            _roleManager = roleManager;
		}

        public async Task CreateUserAsync(UsersDto userDto)
        {
            await _repositoryManager.CreateNew(new Users
            {
                UsersId = userDto.UserIdDto,
                Email = userDto.EmailDto,
                EmailPassword = userDto.EmailPasswordDto,
                Employee = userDto.EmployeeDto,
                FIO = userDto.FIO,
                Login = userDto.LoginDto,
                Password = userDto.PasswordDto,
                Role = _roleManager.GetEntity(c => c.RoleId == userDto.RoleDto.RoleId).GetAwaiter().GetResult(),
                Protocols = null
            });
            await _repositoryManager.SaveChanges();
		}

        public async Task DeleteUserAsync(string login)
        {
            _repositoryManager.Delete( _repositoryManager.GetEntity(c => c.Login == login).GetAwaiter().GetResult());
            await _repositoryManager.SaveChanges();
        }

        public IEnumerable<Users> GetAllUsers()
        {
            var users = _repositoryManager.GetAll().ToList();

            foreach(var item in users)
			{
				item.Role = _roleManager.GetEntity(c => c.RoleId == item.RoleId).GetAwaiter().GetResult();
			}

			return users;
        }

        public async Task<UsersDto> GetUserByLogin(string login)
        {
            var user = await _repositoryManager.GetEntity(c => c.Login == login);

            if (user == null)
                return null;

            return new UsersDto
            {
                UserIdDto = user.UsersId,
                EmailDto = user.Email,
                EmailPasswordDto = user.EmailPassword,
                LoginDto = user.Login,
                PasswordDto = user.Password,
                EmployeeDto = user.Employee,
                FIO = user.FIO,
                ProtocolsDto = null,
                RoleDto = await _roleManager.GetEntity(c => c.RoleId == user.RoleId)
            };
        }

        public async Task UpdateUserAsync(UsersDto userDto)
        {
            var user = await _repositoryManager.GetEntityWithoutTracking(c => c.UsersId == userDto.UserIdDto);

            user.Login = userDto.LoginDto;
            user.Password = userDto.PasswordDto;
            user.Email = userDto.EmailDto;
            user.EmailPassword = userDto.EmailPasswordDto;
            user.Employee = userDto.EmployeeDto;
            user.FIO = userDto.FIO;
            user.Protocols = null;
            user.Role = _roleManager.GetEntity(c => c.RoleId == userDto.RoleDto.RoleId).GetAwaiter().GetResult();

            _repositoryManager.Update(user);
            await _repositoryManager.SaveChanges();
        }
    }
}
