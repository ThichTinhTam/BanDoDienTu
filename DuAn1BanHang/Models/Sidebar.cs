using DuAn1BanHang.Data;
using Microsoft.AspNetCore.Mvc;

namespace DuAn1BanHang.Models
{
    public class Sidebar : ViewComponent
    {
        private readonly DuAn1BanHangContext _context;

        public Sidebar(DuAn1BanHangContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Category.ToList());
        }
    }
}
