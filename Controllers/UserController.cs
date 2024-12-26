using Microsoft.AspNetCore.Mvc;
using Registration.Models;
using Registration.Repository;

namespace Registration.Controllers
{
    public class UserController : Controller
    {   
        public IActionResult Enter()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(User user) 
        {
         
            

            if(user.Particibate is true)
            {
                if (!ModelState.IsValid)
                {
                    return View(user);
                }

                UserRepo.Form(user);
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View(user);
                }
                return RedirectToAction("Notparticibate");
            }
            

            return RedirectToAction("Check", user);
        }

        [HttpGet]
        public IActionResult Check() 
        {
            var user = UserRepo.GetUser();

            var lastUser = user.LastOrDefault();


            if (lastUser.Particibate == true)
            {
                return RedirectToAction("Reply");

            }
            else
            {
                return RedirectToAction("Notparticibate");
            }

        }

        public IActionResult Reply()
        {
            var user = UserRepo.GetUser();

            var lastUser = user.LastOrDefault();

            return View(lastUser);

        }


        [HttpGet]
        public IActionResult List()
        {
            return View(UserRepo.GetUser());
        }


        [HttpGet]
        public IActionResult Notparticibate()
        {
            var user = UserRepo.GetUser();

            var lastUser = user.LastOrDefault();

            return View(lastUser);
        }



    }
}
