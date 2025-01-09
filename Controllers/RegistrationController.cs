using Microsoft.AspNetCore.Mvc;
using Registration.Models;
using Registration.Repository;

namespace Registration.Controllers
{
    public class RegistrationController : Controller
    {
        UserRepo Users = new UserRepo();
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Enter()
        {
            return View("Enter");
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(User user)
        {
            if(user != null)
            {
                UserRepo.Form(user);
                Console.WriteLine($"Name: {user.Name}, Surname: {user.Surname}");
            }
            return View("Test");
        }
    }
}
