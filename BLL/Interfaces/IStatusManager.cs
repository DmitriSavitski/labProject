using BLL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IStatusManager
    {
        Task CreateStatusAsync(StatusDto statusDto);

        Task DeleteStatusAsync(string statusName);

        IEnumerable<StatusDto> GetAllStatuses();

        Task<StatusDto> GetStatusByNameAsync(string statusName);
    }
}
