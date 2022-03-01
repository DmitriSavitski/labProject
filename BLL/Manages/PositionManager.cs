using BLL.Interfaces;
using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Manages
{
    public class PositionManager : IPositionManager
    {
        private readonly IRepositoryManager<Position> _repositoryManager;

        public PositionManager(IRepositoryManager<Position> repositoryManager)
		{
            _repositoryManager = repositoryManager;
		}

        public async Task CreatePositionAsync(PositionDto positionDto)
        {
            _repositoryManager.CreateNew(new Position
            {
                PositionId = positionDto.PositionIdDto,
                Name = positionDto.NameDto
            }).GetAwaiter().GetResult();
            await _repositoryManager.SaveChanges();
        }

        public async Task DeletePositionAsync(int id)
        {
            _repositoryManager.Delete(await _repositoryManager.GetEntity(c => c.PositionId == id));
            await _repositoryManager.SaveChanges();
        }

        public IEnumerable<PositionDto> GetAllPosition()
        {
            var position = _repositoryManager.GetAll().ToList();

            if (position == null)
                return null;

            var positions = new List<PositionDto>();

			foreach (var item in position)
			{
                positions.Add(new PositionDto
                {
                    PositionIdDto = item.PositionId,
                    NameDto = item.Name
                });
			}

            return positions;
        }

        public async Task<Position> GetPositionByIdAsync(int id)
		{
            return await _repositoryManager.GetEntity(c => c.PositionId == id);
		}

        public async Task UpdatePosition(PositionDto positionDto)
		{
            var position = await _repositoryManager.GetEntity(c => c.PositionId == positionDto.PositionIdDto);

            if (position != null)
			{
                position.Name = positionDto.NameDto;
			}

            _repositoryManager.Update(position);
            await _repositoryManager.SaveChanges();
		}
    }
}
