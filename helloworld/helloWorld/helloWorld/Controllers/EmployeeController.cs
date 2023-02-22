using Microsoft.AspNetCore.Mvc;

namespace helloWorld.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
