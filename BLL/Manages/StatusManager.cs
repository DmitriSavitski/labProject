using BLL.Interfaces;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Manages
{
    public class StatusManager : IStatusManager
    {
        public Task CreateStatusAsync(StatusDto statusDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteStatusAsync(string statusName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StatusDto> GetAllStatuses()
        {
            throw new NotImplementedException();
        }

        public Task<StatusDto> GetStatusByNameAsync(string statusName)
        {
            throw new NotImplementedException();
        }
    }
}
