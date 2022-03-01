using BLL.Interfaces;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
	public class PositionController : Controller
	{
		private readonly IPositionManager _positionManager;

		public PositionController(IPositionManager positionManager)
		{
			_positionManager = positionManager;
		}

		public IActionResult Index()
		{
			var pos = _positionManager.GetAllPosition();
			return Json(pos);
		}
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateAsync(PositionDto positionDto)
		{
			await _positionManager.CreatePositionAsync(positionDto);
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> DeleteAsync(int id)
		{
			await _positionManager.DeletePositionAsync(id);

			return RedirectToAction("Index");
		}

		[HttpGet]
		public async Task<IActionResult> UpdateAsync(int id)
		{
			var pos =  _positionManager.GetPositionByIdAsync(id).GetAwaiter().GetResult();

			return Json(new PositionDto
			{
				PositionIdDto = pos.PositionId,
				NameDto = pos.Name
			});
		}

		[HttpPost]
		public async Task<IActionResult> UpdateAsync(PositionDto positionDto)
		{
			await _positionManager.UpdatePosition(positionDto);

			return RedirectToAction("Index");
		}
	}
}
