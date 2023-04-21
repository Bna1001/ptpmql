using baithuchanh1303.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;



namespace baithuchanh1303.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            string ketqua = std.StudentCode + "-" + std.FullName + "-" + std.Address;
            ViewBag.message = ketqua;
            return View();
        }
    }
}
