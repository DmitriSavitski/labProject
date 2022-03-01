using BLL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IProtocolManager
    {
        Task CreateProtocolAsync(ProtocolDto protocolDto);

        Task DeleteProtocolAsync(string protocolId);

        IEnumerable<ProtocolDto> GetAllUsersProtocols(string userLogin);
    }
}
