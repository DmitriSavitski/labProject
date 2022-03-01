using BLL.Interfaces;
using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Manages
{
    public class LeadersManager : ILeadersManager
    {
        private readonly IRepositoryManager<Leaders> _repositoryManager;

        public LeadersManager(IRepositoryManager<Leaders> repositoryManager)
		{
            _repositoryManager = repositoryManager;
		}

        public async Task CreateLeaderAsync(LeadersDto leadersDto)
        {
            var leader = new Leaders
            {
                LeadersId = leadersDto.LeaderIdDto,
            };

            await _repositoryManager.CreateNew(leader);
            await _repositoryManager.SaveChanges();
        }

        public async Task DeleteLeaderAsync(string leaderName)
        {
            _repositoryManager.Delete(await _repositoryManager.GetEntity(c => c.Employee.FIO.LastName == leaderName));
            await _repositoryManager.SaveChanges();
        }

        public IEnumerable<LeadersDto> GetAllLeaders()
        {
            return (IEnumerable<LeadersDto>)_repositoryManager.GetAll();
        }

        public async Task<Leaders> GetLeaderByDepartment(string departmentName)
        {
            var leader =  await _repositoryManager.GetEntity(c => c.Departments.Name == departmentName);

            if (leader == null)
                return null;

            return leader;
        }

        public async Task<Leaders> GetLeaderById(int id)
		{
            var x = await _repositoryManager.GetEntity(c => c.EmployeesId == id);

            if (x == null)
                return null;

            return x;
		}
    }
}
