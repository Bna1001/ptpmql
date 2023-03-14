using baithuchanh1303.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using baithuchanh1303.Models.Process;
namespace baithuchanh1303.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult GPTB1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GPTB1(string heSoA,String heSoB)
        {
            string thongbao = "";
            double a = 0, b = 0;
            if(!string.IsNullOrEmpty(heSoA))a= Convert.ToDouble(heSoA);
            if(!string.IsNullOrEmpty(heSoB))b= Convert.ToDouble(heSoB);
            if (a == 0)
            {
                thongbao = "day khong phai phuong trinh bac 1";
            }
            else
            {
                thongbao = gpt.GiaiPhuongTrinhB1(a, b);
            }
            ViewBag.message = thongbao;
            return View();
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