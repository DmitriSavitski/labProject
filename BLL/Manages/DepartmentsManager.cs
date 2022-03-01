using BLL.Interfaces;
using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Manages
{
	public class DepartmentsManager : IDepartmentsManager
	{
		private readonly IRepositoryManager<Departments> _repositoryManager;
		private readonly ILeadersManager _leadersManager;
		private readonly IRepositoryManager<Employees> _employeesManages;
		private readonly IPositionManager _positionManager;
		private readonly IFIOManager _fIOManager;

		public DepartmentsManager(IRepositoryManager<Departments> repositoryManager, ILeadersManager leadersManager, IRepositoryManager<Employees> employeesManages, IPositionManager positionManager, IFIOManager fIOManager)
		{
			_repositoryManager = repositoryManager;
			_leadersManager = leadersManager;
			_employeesManages = employeesManages;
			_positionManager = positionManager;
			_fIOManager = fIOManager;
		}

		public async Task CreateDepartmentAsync(DepartmentsDto departmentDto)
		{
			if (departmentDto != null)
			{

				var department = new Departments
				{
					DepartmentsId = departmentDto.DepartmentIdDto,
					Name = departmentDto.NameDto,
				};

				await _repositoryManager.CreateNew(department);
				await _repositoryManager.SaveChanges();
			}

		}

		public async Task DeleteDepartmentAsync(int id)
		{
			_repositoryManager.Delete(await _repositoryManager.GetEntity(c => c.DepartmentsId == id));

			await _repositoryManager.SaveChanges();
		}

		public IEnumerable<DepartmentsDto> GetAllDepartments()
		{
			var departments = _repositoryManager.GetAll().ToList();

			var departmentsDto = new List<DepartmentsDto>();

			foreach (var item in departments)
			{
				departmentsDto.Add(new DepartmentsDto
				{
					DepartmentIdDto = item.DepartmentsId,
					NameDto = item.Name,
					Employee = GetAllDepartmentEmployees(item.Name).ToList()
				});
			}

			return departmentsDto;
		}

		public async Task<DepartmentsDto> GetDepartmentDtoByIdAsync(int id)
		{
			var dep = _repositoryManager.GetEntity(c => c.DepartmentsId == id).GetAwaiter().GetResult();

			return new DepartmentsDto
			{
				DepartmentIdDto = dep.DepartmentsId,
				NameDto = dep.Name,
				Employee = GetAllDepartmentEmployees(dep.Name).ToList()
			};
		}

		public async Task<Departments> GetDepartmentByIdAsync(int id)
		{
			return await _repositoryManager.GetEntity(c => c.DepartmentsId == id);
		}

		public async Task UpdateDepartmentInfo(Departments departmentDto)
		{
			var department = await _repositoryManager.GetEntity(c => c.DepartmentsId == departmentDto.DepartmentsId);

			if (department != null)
			{
				department.Name = departmentDto.Name;
			}

			_repositoryManager.Update(department);
			await _repositoryManager.SaveChanges();
		}

		public List<EmployeesDto> GetDepartmnetEmployees(string departmentName)
		{
			var list = GetAllDepartmentEmployees(departmentName).ToList();

			var employees = new List<EmployeesDto>();

			foreach (var item in list)
			{
				employees.Add(new EmployeesDto
				{
					EmailDto = item.EmailDto,
					FIODto = item.FIODto,
					PositionDto = item.PositionDto
				});
			}

			return employees;
		}

		public IEnumerable<EmployeesDto> GetAllDepartmentEmployees(string departmentName)
		{
			var employees = _employeesManages.GetAll().Where(c => c.Department.Name == departmentName);

			var employeesDto = new List<EmployeesDto>();

			foreach (var item in employees)
			{
				employeesDto.Add(new EmployeesDto
				{
					EmployeeIdDto = item.EmployeesId,
					EmailDto = item.Email,
					FIODto = _fIOManager.GetFIOByIdAsync(item.FIOId).GetAwaiter().GetResult(),
					PositionDto = _positionManager.GetPositionByIdAsync(item.PositionId).GetAwaiter().GetResult()
				});
			}

			return employeesDto;
		}
	}
}
