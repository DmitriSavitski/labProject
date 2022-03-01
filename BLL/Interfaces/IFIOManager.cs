using BLL.Models;
using DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IFIOManager
    {
        Task CreateFIOAsync(FIODto fIODto);

        Task DeleteFIOAsync(int fioId);

        IEnumerable<FIO> GetAllFIOs();

        Task<FIO> GetFIOByIdAsync(int id);

        Task<FIO> GetFIOByLastNameAsync(string lastName);

        Task UpdateFIO(FIO fioDto);
    }
}
