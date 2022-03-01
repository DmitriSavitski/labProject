using BLL.Interfaces;
using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Manages
{
    public class FIOManager : IFIOManager
    {
        private readonly IRepositoryManager<FIO> _repositoryManager;

        public FIOManager(IRepositoryManager<FIO> repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task CreateFIOAsync(FIODto fIODto)
        {
            var fio = new FIO()
            {
                LastName = fIODto.LastNameDto,
                FirstName = fIODto.FirstNameDto,
                MiddleName = fIODto.MiddleNameDto
            };

            await _repositoryManager.CreateNew(fio);
            await _repositoryManager.SaveChanges();
        }

        public async Task DeleteFIOAsync(int fioId)
        {
            _repositoryManager.Delete(await _repositoryManager.GetEntity(c => c.FIOId == fioId));
            await _repositoryManager.SaveChanges();
        }

        public IEnumerable<FIO> GetAllFIOs()
        {
            return _repositoryManager.GetAll();
        }

		public async Task<FIO> GetFIOByIdAsync(int id)
		{
            return await _repositoryManager.GetEntity(c => c.FIOId == id);
		}

        public async Task<FIO> GetFIOByLastNameAsync(string lastName)
		{
            return await _repositoryManager.GetEntity(c => c.LastName == lastName);
        }

        public async Task UpdateFIO(FIO fioDto)
		{
            var fio = await _repositoryManager.GetEntity(c => c.FIOId == fioDto.FIOId);

            if(fio != null)
			{
                fio.LastName = fioDto.LastName;
                fio.FirstName = fioDto.FirstName;
                fio.MiddleName = fioDto.MiddleName;
			}

            _repositoryManager.Update(fio);
            await _repositoryManager.SaveChanges();
		}
	}
}
