using Microsoft.AspNetCore.Mvc;
namespace baithuchanh2002.Controllers
{
    public class StudentController: Controller
    {
        public StudentController()
        {
        }

        public IActionResult Index() 
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}

