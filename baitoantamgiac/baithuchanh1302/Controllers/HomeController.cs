using baithuchanh1302.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using baithuchanh1302.Models.Process;

namespace baithuchanh1302.Controllers
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
        public IActionResult GPTB1(string heSoA ,string heSoB)
        {
            string thongbao = "";
            double a = 0, b = 0;
            if (!string.IsNullOrEmpty(heSoA)) a = Convert.ToDouble(heSoA);
            if (!string.IsNullOrEmpty(heSoB)) b = Convert.ToDouble(heSoB);
            if (a == 0)
            {
                thongbao = "khong phai phuong trinh bac 1";
            }
            else
            {
                thongbao = gpt.GiaiPhuongTrinhB1(a, b);
            }
            ViewBag.message = thongbao;
            return View();
        }
        public IActionResult GBTTG() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult GBTTG(int heSoA,int heSoB,int heSoC) 
        {
            string thongbao="";
            int a, b, c, x, y, z;
            a = Convert.ToInt32(heSoA);
            b = Convert.ToInt32(heSoB);
            c= Convert.ToInt32(heSoC);
            x = a * a;
            y = b * b;
            z= c * c;
            if (a + b > c && b + c > a && c + a > b)
            {
                if (x == y || y == z || z == x)
                {
                    if (x == y && y == z) thongbao = "day la tam giac deu";
                    else
                    {
                        if (x == y + z || z == x + y || y == x + z) thongbao = "day la tam giac vuong can";
                        else thongbao = "day la tam giac can";
                    }
                }
                else
                {
                    if (x == y + z || y == x + z || z == x + y) thongbao = "tam giac vuong";
                    else thongbao = "tam giac thuong";
                }
            }
            else
                thongbao = "ba canh khong phai tam giac";
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