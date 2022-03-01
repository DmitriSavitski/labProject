using BLL.Interfaces;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Manages
{
    public class ProtocolManager : IProtocolManager
    {
        public Task CreateProtocolAsync(ProtocolDto protocolDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProtocolAsync(string protocolId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProtocolDto> GetAllUsersProtocols(string userLogin)
        {
            throw new NotImplementedException();
        }
    }
}
