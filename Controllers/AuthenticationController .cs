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
            return RedirectToAction("Index", "Home");

         
        }
        public IActionResult Register()
        {

            return View();
        }
    }
}
