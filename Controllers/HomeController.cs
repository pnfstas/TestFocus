using Microsoft.AspNetCore.Mvc;

namespace TestFocus.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Start()
        {
            return View("Start");
        }
    }
}
