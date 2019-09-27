using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StaticListExample.Models;

namespace StaticListExample.Controllers
{
	public class HomeController : Controller
	{
		private static List<CarModel> _allModels;
		private CarModelContext _context;

		public HomeController(CarModelContext context)
		{
			_context = context;

			if (_allModels == null)
			{
				_allModels = _context
					.CarModels
					.ToList();
			}
		}

		public IActionResult Index()
		{
			return View(_allModels);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
