using BLL.Interfaces;
using DAL.Context;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ApplicationContext _applicationContext;
		private readonly IRoleManager _roleManager;

		public HomeController(ApplicationContext applicationContext, IRoleManager roleManager)
		{
			_applicationContext = applicationContext;
			_roleManager = roleManager;
		}

		public async Task<IActionResult> IndexAsync()
		{
			if (_applicationContext.Role.FirstOrDefault() == null)
			{
				var role = new Role { Name = "Admin"};
				_applicationContext.Role.Add(role);
				_applicationContext.SaveChanges();
			}

			if(_applicationContext.Users.FirstOrDefault() == null)
			{
				var rolea = await _roleManager.GetRoleByName("Admin");

				var user = new Users { Login = "admin", Password = "admin", Role = rolea};
				_applicationContext.Users.Add(user);
				_applicationContext.SaveChanges();

			}

			if(_applicationContext.Departments.FirstOrDefault() == null)
			{
				var dep = new Departments { Name = "Руководство" };
				_applicationContext.Departments.Add(dep);
				_applicationContext.SaveChanges();
			}

			if (User.Identity.IsAuthenticated)
				return View();
			else
				return RedirectToAction("SignIn", "Authorization");

		}
	}
}
