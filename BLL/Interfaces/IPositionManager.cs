using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IPositionManager
    {
        Task CreatePositionAsync(PositionDto positionDto);

        Task DeletePositionAsync(int id);

        IEnumerable<PositionDto> GetAllPosition();

        Task<Position> GetPositionByIdAsync(int id);

        Task UpdatePosition(PositionDto positionDto);
    }
}
