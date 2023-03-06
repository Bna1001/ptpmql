using Microsoft.AspNetCore.Mvc;

namespace helloWorld.Controllers
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

    }
}
