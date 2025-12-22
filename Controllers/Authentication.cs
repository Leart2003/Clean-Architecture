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
    }
}
