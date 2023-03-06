using Baithuchanh0703.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Baithuchanh0703.Controllers
{
    public class HomeController : Controller
    {
        // 1 controller có thể tạo nhiều Action
        // 1 hàm action chỉ tạo được 1 view 
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
