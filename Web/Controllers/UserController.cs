using BLL.Interfaces;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
	public class UserController : Controller
	{
		private readonly IUsersManager _userManager;
		private readonly IRoleManager _roleManager;

		public UserController(IUsersManager userManager, IRoleManager roleManager)
		{
			_userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
			_roleManager = roleManager ?? throw new ArgumentNullException(nameof(roleManager));
		}

		[HttpGet]
		public IActionResult Create()
		{
			var roles = _roleManager.GetAllRoles();

			ViewBag.Roles = roles;

			return View();
		}

		[HttpPost]
		public IActionResult Create(UsersDto usersDto)
		{
			_userManager.CreateUserAsync(usersDto).GetAwaiter().GetResult();

			return RedirectToAction("Index", "User");
		}

		public IActionResult Index()
		{
			var users = _userManager.GetAllUsers();

			return Json(users);
		}

		public async Task<IActionResult> DeleteAsync(string login)
		{
			await _userManager.DeleteUserAsync(login);

			return RedirectToAction("Index", "User");
		}

		[HttpGet]
		public IActionResult Update(string login)
		{
			var roles = _roleManager.GetAllRoles();

			ViewBag.Roles = roles;
			return Json(_userManager.GetUserByLogin(login).GetAwaiter().GetResult());
		}

		[HttpPost]
		public async Task<IActionResult> UpdateAsync(UsersDto usersDto)
		{
			await _userManager.UpdateUserAsync(usersDto);

			return RedirectToAction("Index", "User");
		}
	}
}
