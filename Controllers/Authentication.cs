using Microsoft.AspNetCore.Mvc;

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

            return View();
        }
        public IActionResult LoginSubmit(string emailAdress, string password)
        {

            return View();
        }
        public IActionResult Register()
        {

            return View();
        }
    }
}
