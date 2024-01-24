using DuAn1BanHang.Data;
using Microsoft.AspNetCore.Mvc;

namespace DuAn1BanHang.Models
{
	public class Navbar : ViewComponent
	{
		//lay du lieu truyen vao trong view 
		private readonly DuAn1BanHangContext _context;

		public Navbar(DuAn1BanHangContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
	}
}
