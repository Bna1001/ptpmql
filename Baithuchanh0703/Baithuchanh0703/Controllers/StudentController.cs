using Microsoft.AspNetCore.Mvc;

namespace Baithuchanh0703.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(String FullName)
        {
            string strReturn = "Hello" + FullName;
            //gui du lieu ve view
            ViewBag.abc = strReturn;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult TinhTong()
        {
            return View();
        }
        [HttpPost]

        public IActionResult TinhTong(string Number)
        {
            int so = Convert.ToInt32(Number);
            int tong = 0;
            while (so > 0)
            {
                tong = tong + so % 10;
                so = so / 10;
            }
            ViewBag.Sum = "tong cac chu so cua so" + Number + "=" tong;
            return View();
        }
    }
}
