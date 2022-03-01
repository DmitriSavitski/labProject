using BLL.Interfaces;
using BLL.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
	public class AuthorizationController : Controller
	{
		private readonly ILogger<AuthorizationController> _logger;
		private readonly IUsersManager _userManager;

		public AuthorizationController(ILogger<AuthorizationController> logger, IUsersManager userManager)
		{
			_logger = logger;
			_userManager = userManager;
		}

		[HttpGet]
		public IActionResult SignIn()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> SignInAsync(UserAuthViewModel userViewModel)
		{
			if (!ModelState.IsValid)
			{
				return Json(userViewModel);
			}

			var user = _userManager.GetUserByLogin(userViewModel.Login).GetAwaiter().GetResult();

			bool isSuccses = _userManager.GetUserByLogin(userViewModel.Login).GetAwaiter().GetResult() == null ? false : true;

			switch (isSuccses)
			{
				case true:
					userViewModel.redirectUrl = "https://localhost:5001/Home/Index";
					await Authenticate(user);
					return Json(userViewModel);
				case false:
					ModelState.AddModelError("", "Ошибка входа! Проверьте имя пользователя и пароль");
					return Json(userViewModel);
			}
		}

		private async Task Authenticate(UsersDto user)
		{
			var claims = new List<Claim>
			{
				new Claim(ClaimsIdentity.DefaultNameClaimType, user.LoginDto),
				new Claim(ClaimsIdentity.DefaultRoleClaimType, user.RoleDto?.Name)
			};

			ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
				ClaimsIdentity.DefaultRoleClaimType);

			await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
		}

		[HttpPost]
		public async Task<IActionResult> LogOffAsync()
		{
			await HttpContext.SignOutAsync();
			return RedirectToAction("SignIn", "Authorization");
		}
	}
}
