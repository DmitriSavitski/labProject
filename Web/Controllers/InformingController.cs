using BLL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Web.Helpers;

namespace Web.Controllers
{
	public class InformingController : Controller
	{
		private readonly IEmployeesManages _employeesManager;
		private readonly IDepartmentsManager _departmentsManager;
		private readonly IUsersManager _userManager;

		public InformingController(IEmployeesManages employeesManager, IDepartmentsManager departmentsManager, IUsersManager usersManager)
		{
			_employeesManager = employeesManager;
			_departmentsManager = departmentsManager;
			_userManager = usersManager;
		}

		[HttpGet]
		public IActionResult Index()
		{

			var emp = _employeesManager.GetAllEmployees().ToList().FirstOrDefault() == null ? null : _employeesManager.GetAllEmployees().ToList();

			var employees = new List<EmployeeInfModel>();

			foreach (var item in emp)
			{
				var fioArr = new string[3] { item.FIODto.LastName, item.FIODto.FirstName, item.FIODto.MiddleName };
				employees.Add(new EmployeeInfModel
				{
					Id = item.EmployeeIdDto,
					Fio = String.Join(" ", fioArr)
				});
			}

			var departments = _departmentsManager.GetAllDepartments().ToList().FirstOrDefault() == null ? null : _departmentsManager.GetAllDepartments().ToList();

			ViewBag.Employees = employees;
			ViewBag.Departments = departments;

			return View();
		}

		[HttpPost]
		public bool Index(int id, string text)
		{
			var email = _employeesManager.GetEmployeeByIdAsync(id).GetAwaiter().GetResult().EmailDto;
			var login = HttpContext.User.FindFirst(ClaimTypes.Name).ToString().Split(':')[2].Trim();

			var user = _userManager.GetUserByLogin(login).GetAwaiter().GetResult();

			bool isSuccess = InformingHelper.SendInfo(email, text, user);

			return isSuccess;
		}

		public ActionResult Filter(int depName)
		{
			var emp = _employeesManager.GetAllDepartmentByIdEmployees(depName).ToList();

			var list = new List<SelectListItem>();

			foreach (var item in emp)
			{
				var fioArr = new string[3] { item.FIODto.LastName, item.FIODto.FirstName, item.FIODto.MiddleName };
				list.Add(new SelectListItem
				{
					Value = item.EmployeeIdDto.ToString(),
					Text = string.Join(" ", fioArr)
				});
			}

			return Json(list);
		}
	}

	public class InformingViewModel
	{
		public List<Employees> Employees { get; set; }

		public List<Departments> Departments { get; set; }

		public string Text { get; set; }
	}

	public class EmployeeInfModel
	{
		public int Id { get; set; }

		public string Fio { get; set; }
	}
}
