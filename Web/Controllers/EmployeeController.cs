using BLL.Interfaces;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
	public class EmployeeController : Controller
	{
		private readonly IEmployeesManages _employeeManager;
		private readonly INationalityManager _nationalityManager;
		private readonly IPositionManager _positionManager;
		private readonly IFIOManager _fioManager;
		private readonly IDepartmentsManager _departmentsManager;


		public EmployeeController(IEmployeesManages employeeManager, INationalityManager nationalityManager, IPositionManager positionManager, IFIOManager fioManager, IDepartmentsManager departmentsManager)
		{
			_employeeManager = employeeManager ?? throw new ArgumentNullException(nameof(employeeManager));
			_nationalityManager = nationalityManager ?? throw new ArgumentNullException(nameof(nationalityManager));
			_positionManager = positionManager ?? throw new ArgumentNullException(nameof(positionManager));
			_fioManager = fioManager ?? throw new ArgumentNullException(nameof(fioManager));
			_departmentsManager = departmentsManager;
		}
		public IActionResult Index()
		{
			var employees = _employeeManager.GetAllEmployees();

			return Json(employees);
		}

		[HttpGet]
		public IActionResult Create()
		{
			var positions = _positionManager.GetAllPosition().ToList();
			var departments = _departmentsManager.GetAllDepartments();

			ViewBag.Departments = departments;
			ViewBag.Positions = positions;

			return View();
		}

		[HttpPost]
		public ActionResult Create(EmployeesDto employeesDto)
		{
			_employeeManager.CreateEmployeeAsync(employeesDto).GetAwaiter().GetResult();

			return RedirectToAction("Index");
		}

		public async Task<IActionResult> DeleteAsync(int id)
		{
			await _employeeManager.DeleteEmployeeAsync(id);

			return RedirectToAction("Index");
		}

		[HttpGet]
		public async Task<IActionResult> UpdateAsync(int id)
		{
			var employee = await _employeeManager.GetEmployeeByIdAsync(id);
			var positions = _positionManager.GetAllPosition().ToList();
			var departments = _departmentsManager.GetAllDepartments().ToList();

			ViewBag.Departments = departments;
			ViewBag.Positions = positions;

			return Json(employee);
		}

		[HttpPost]
		public async Task<IActionResult> UpdateAsync(EmployeesDto employeesDto)
		{
			await _employeeManager.UpdateEmployeeInfo(employeesDto);

			return RedirectToAction("Index");
		}
	}

	public class DepartmnetsViewModel
	{
		public int DepartmentsId { get; set; }

		public string Name { get; set; }
	}
}
