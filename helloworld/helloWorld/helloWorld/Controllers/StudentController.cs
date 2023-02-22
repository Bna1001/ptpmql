using Microsoft.AspNetCore.Mvc;

namespace helloWorld.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
