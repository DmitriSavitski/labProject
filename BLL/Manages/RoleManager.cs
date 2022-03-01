using BLL.Interfaces;
using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Manages
{
	public class RoleManager : IRoleManager
	{
		private readonly IRepositoryManager<Role> _repositoryManager;

		public RoleManager(IRepositoryManager<Role> repositoryManager)
		{
			_repositoryManager = repositoryManager;
		}

		public async Task CreateRoleAsync(RoleDto roleDto)
		{
			await _repositoryManager.CreateNew(new Role
			{
				RoleId = roleDto.RoleIdDto,
				Name = roleDto.NameDto
			});
		}

		public async Task DeleteRoleAsync(string roleName)
		{
			_repositoryManager.Delete(await _repositoryManager.GetEntity(c => c.Name == roleName));
			await _repositoryManager.SaveChanges();
		}

		public IEnumerable<RoleDto> GetAllRoles()
		{
			var roles = _repositoryManager.GetAll();

			var rolesDto = new List<RoleDto>();

			foreach (var item in roles)
			{
				rolesDto.Add(new RoleDto
				{
					RoleIdDto = item.RoleId,
					NameDto = item.Name
				});
			}

			return rolesDto;
		}

		public async Task<Role> GetRoleByName(string roleName)
		{
			var role = await _repositoryManager.GetEntity(c => c.Name == roleName);

			if (role == null)
				return null;

			return role;
		}

		public Role GetRoleByIdAsync(int id)
		{
			var role = _repositoryManager.GetEntity(c => c.RoleId == id).GetAwaiter().GetResult();

			if (role == null)
				return null;

			return role;
		}
	}
}
