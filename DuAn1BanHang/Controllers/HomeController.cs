using DuAn1BanHang.Data;
using DuAn1BanHang.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DuAn1BanHang.Controllers
{
    public class HomeController : Controller
    {
		private readonly DuAn1BanHangContext _context;

		public HomeController(DuAn1BanHangContext context)
		{
			_context = context;
		}

		public IActionResult Index()
        {
            return View(_context.Product.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}