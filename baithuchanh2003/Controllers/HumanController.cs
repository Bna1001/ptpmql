using Microsoft.AspNetCore.Mvc;
using baithuchanh2003.Models;
using baithuchanh2003.Data;
using Microsoft.EntityFrameworkCore;

namespace baithuchanh2003.Controllers
{
    public class HumanController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HumanController (ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Humans.ToListAsync(); //phuong thuc tra ve list nhân viên
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Human std)
        {
            if(ModelState.IsValid) //kiểm tra rằng buộc trong model
            {
                _context.Add(std);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}