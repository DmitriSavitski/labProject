using BLL.Interfaces;
using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Manages
{
	public class EmployeesManager : IEmployeesManages
	{
		private readonly IRepositoryManager<Employees> _repositoryManager;
		private readonly IPositionManager _positionManager;
		private readonly IDepartmentsManager _departmentsManager;
		private readonly IFIOManager _fIOManager;
		private readonly INationalityManager _nationalityManager;

		public EmployeesManager(IRepositoryManager<Employees> repositoryManager, IPositionManager positionManager, IDepartmentsManager departmentsManager,
								IFIOManager fIOManager, INationalityManager nationalityManager)
		{
			_repositoryManager = repositoryManager;
			_positionManager = positionManager;
			_departmentsManager = departmentsManager;
			_fIOManager = fIOManager;
			_nationalityManager = nationalityManager;
		}

		public async Task CreateEmployeeAsync(EmployeesDto employeeDto)
		{
			await _fIOManager.CreateFIOAsync(new FIODto
			{
				LastNameDto = employeeDto.FIODto.LastName,
				FirstNameDto = employeeDto.FIODto.FirstName,
				MiddleNameDto = employeeDto.FIODto.MiddleName
			});

			var employee = new Employees()
			{
				EmployeesId = employeeDto.EmployeeIdDto,
				Email = employeeDto.EmailDto,
				FIOId = employeeDto.fioId,
				PositionId = employeeDto.positionId,
				DepartmentsId = employeeDto.departmentId,
				FIO = _fIOManager.GetFIOByLastNameAsync(employeeDto.FIODto.LastName).GetAwaiter().GetResult(),
				Department = _departmentsManager.GetDepartmentByIdAsync(employeeDto.DepartmentDto.DepartmentsId).GetAwaiter().GetResult(),
				Position = _positionManager.GetPositionByIdAsync(employeeDto.PositionDto.PositionId).GetAwaiter().GetResult()
			};

			await _repositoryManager.CreateNew(employee);
			await _repositoryManager.SaveChanges();
		}

		public async Task DeleteEmployeeAsync(int employeeId)
		{
			_repositoryManager.Delete(await _repositoryManager.GetEntity(c => c.EmployeesId == employeeId));
			await _repositoryManager.SaveChanges();
		}

		public IEnumerable<EmployeesDto> GetAllDepartmentEmployees(string departmentName)
		{
			var employees = _repositoryManager.GetAll().Where(c => c.Department.Name == departmentName);

			var employeesDto = new List<EmployeesDto>();

			foreach (var item in employees)
			{
				employeesDto.Add(new EmployeesDto
				{
					EmployeeIdDto = item.EmployeesId,
					EmailDto = item.Email,
					DepartmentDto = _departmentsManager.GetDepartmentByIdAsync((int)item.DepartmentsId).GetAwaiter().GetResult(),
					FIODto = _fIOManager.GetFIOByIdAsync(item.FIO.FIOId).GetAwaiter().GetResult(),
					PositionDto = _positionManager.GetPositionByIdAsync(item.Position.PositionId).GetAwaiter().GetResult()
				});
			}

			return employeesDto;
		}

		public IEnumerable<EmployeesDto> GetAllEmployees()
		{
			var employees = (IEnumerable<Employees>)_repositoryManager.GetAll();

			var employeesDto = new List<EmployeesDto>();

			foreach (var item in employees)
			{
				employeesDto.Add(new EmployeesDto
				{
					EmployeeIdDto = item.EmployeesId,
					EmailDto = item.Email,
					DepartmentDto = _departmentsManager.GetDepartmentByIdAsync(item.DepartmentsId).GetAwaiter().GetResult(),
					FIODto = _fIOManager.GetFIOByIdAsync(item.FIOId).GetAwaiter().GetResult(),
					PositionDto = _positionManager.GetPositionByIdAsync(item.PositionId).GetAwaiter().GetResult()
				});
			}

			return employeesDto;
		}

		public async Task UpdateEmployeeInfo(EmployeesDto employeeDto)
		{
			var employee = await _repositoryManager.GetEntity(c => c.EmployeesId == employeeDto.EmployeeIdDto);

			if (employee != null)
			{
				employee.EmployeesId = employeeDto.EmployeeIdDto;
				employee.Email = employeeDto.EmailDto;
				employee.DepartmentsId = employeeDto.DepartmentDto.DepartmentsId;
				await _fIOManager.UpdateFIO(employeeDto.FIODto);
				employee.PositionId = employeeDto.PositionDto.PositionId;
			}

			_repositoryManager.Update(employee);
			await _repositoryManager.SaveChanges();
		}

		public async Task<EmployeesDto> GetEmployeeByIdAsync(int id)
		{
			var employee = await _repositoryManager.GetEntity(c => c.EmployeesId == id);

			return new EmployeesDto
			{
				EmployeeIdDto = employee.EmployeesId,
				EmailDto = employee.Email,
				DepartmentDto = _departmentsManager.GetDepartmentByIdAsync((int)employee.DepartmentsId).GetAwaiter().GetResult(),
				FIODto = _fIOManager.GetFIOByIdAsync(employee.FIOId).GetAwaiter().GetResult(),
				PositionDto = _positionManager.GetPositionByIdAsync(employee.PositionId).GetAwaiter().GetResult()
			};
		}

		public IEnumerable<EmployeesDto> GetAllDepartmentByIdEmployees(int id)
		{
			var employees = _repositoryManager.GetAll().Where(c => c.DepartmentsId == id);

			var employeesDto = new List<EmployeesDto>();

			foreach (var item in employees)
			{
				employeesDto.Add(new EmployeesDto
				{
					EmployeeIdDto = item.EmployeesId,
					EmailDto = item.Email,
					FIODto = _fIOManager.GetFIOByIdAsync(item.FIOId).GetAwaiter().GetResult(),
				});
			}

			return employeesDto;
		}
	}
}
