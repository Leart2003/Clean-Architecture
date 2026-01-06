using Microsoft.AspNetCore.Mvc;
using ShortUrl.Data.ViewModel;

namespace ShortUrl.Controllers
{
    public class Authentication : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
         
            return View(new LoginVm());
        }
        [HttpPost]
        public IActionResult LoginSubmit(LoginVm model)
        {

            if (!ModelState.IsValid)
            {
                return View("Login", model); 
            }
            return RedirectToAction("Index", "Home");

         
        }
        public IActionResult Register(RegisterVM registerVM)
        {

            return View();
        }
        public IActionResult RegisterUser(RegisterVM registerVM) {


            return RedirectToAction("Index","Home");
        
         }
            
    }
}
