using BLL.Models;
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ILeadersManager
    {
        Task CreateLeaderAsync(LeadersDto leadersDto);

        Task DeleteLeaderAsync(string leaderName);

        IEnumerable<LeadersDto> GetAllLeaders();

        Task<Leaders> GetLeaderByDepartment(string departmentName);

        Task<Leaders> GetLeaderById(int id);
	}
}
