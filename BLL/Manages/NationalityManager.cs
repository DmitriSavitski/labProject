using BLL.Interfaces;
using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Manages
{
    public class NationalityManager : INationalityManager
    {
        private readonly IRepositoryManager<Nationality> _repositoryManager;

        public NationalityManager(IRepositoryManager<Nationality> repositoryManager)
		{
            _repositoryManager = repositoryManager;
		}

        public async Task CreateNationalityAsync(NationalityDto nationalityDto)
        {
            await _repositoryManager.CreateNew(new Nationality
            {
                NationalityId = nationalityDto.NationalityIdDto,
                Name = nationalityDto.NameDto
            });
            await _repositoryManager.SaveChanges();
        }

        public async Task DeleteNationalityAsync(string nationalityName)
        {
            _repositoryManager.Delete(await _repositoryManager.GetEntity(c => c.Name == nationalityName));
            await _repositoryManager.SaveChanges();
        }

		IEnumerable<NationalityDto> INationalityManager.GetAllNationalitiesAsync()
		{
            return (IEnumerable<NationalityDto>)_repositoryManager.GetAll();
        }
	}
}
