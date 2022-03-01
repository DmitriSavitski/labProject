using BLL.Interfaces;
using BLL.Models;
using DAL.Context;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
	public class DepartmentController : Controller
	{
		private readonly IDepartmentsManager _departmentsManager;
		private readonly IEmployeesManages _employeesManages;
		private readonly ApplicationContext _applicationContext;

		public DepartmentController(IDepartmentsManager departmentsManager, IEmployeesManages employeesManages, ApplicationContext applicationContext)
		{
			_departmentsManager = departmentsManager;
			_employeesManages = employeesManages;
			_applicationContext = applicationContext;
		}

		public ActionResult Index()
		{
			var departments = _departmentsManager.GetAllDepartments().ToList();
			departments.ForEach(c => c.Employee = _departmentsManager.GetDepartmnetEmployees(c.NameDto));

			return Json(departments);
		}

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<ActionResult> CreateAsync(DepartmentsDto departmentsDto)
		{
			await _departmentsManager.CreateDepartmentAsync(departmentsDto);

			return RedirectToAction(nameof(Index));
		}

		public async Task<ActionResult> UpdateAsync(int id)
		{
			var x = await _departmentsManager.GetDepartmentByIdAsync(id);

			return Json(x);
		}

		[HttpPost]
		public async Task<ActionResult> UpdateAsync(Departments departments)
		{

			await _departmentsManager.UpdateDepartmentInfo(departments);

			return RedirectToAction(nameof(Index));
		}


		public async Task<ActionResult> DeleteAsync(int id, string name)
		{
			_applicationContext.Departments.Find(id).Employee.Clear();

			await _departmentsManager.DeleteDepartmentAsync(id);

			return RedirectToAction(nameof(Index));
		}

		[HttpGet]
		public async Task<ActionResult> SetLeaderAsync(int id)
		{
			var dep = await _departmentsManager.GetDepartmentDtoByIdAsync(id);

			var emp = _departmentsManager.GetAllDepartmentEmployees(dep.NameDto);

			var employees = new List<EmployeeViewModel>();

			foreach (var item in emp)
			{
				var fioArr = new string[3] { item.FIODto.LastName, item.FIODto.FirstName, item.FIODto.MiddleName };
				employees.Add(new EmployeeViewModel
				{
					EmployeesId = item.EmployeeIdDto,
					fio = String.Join(" ", fioArr)
				});
			}

			ViewBag.Employees = employees;

			return Json(dep);
		}

		[HttpPost]
		public async Task<ActionResult> SetLeaderAsync(Departments departmentsDto)
		{
			await _departmentsManager.UpdateDepartmentInfo(departmentsDto);
			return RedirectToAction(nameof(Index));
		}
	}

	public class EmployeeViewModel
	{
		public int EmployeesId { get; set; }

		public string fio { get; set; }
	}
}
