using Microsoft.AspNetCore.Mvc;
using baithuchanh1303.Models;
namespace baithuchanh1303.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee std)
        {
            string ketqua = std.EmployeeCode + "-" + std.FullName + "-" + std.Address;
            ViewBag.message = ketqua;
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
