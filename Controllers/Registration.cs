using Microsoft.AspNetCore.Mvc;

namespace Registration.Controllers
{
    public class Registration : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Enterance()
        {
            return View("Enterance");
        }
    }
}
