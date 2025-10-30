using Microsoft.AspNetCore.Mvc;

namespace ShortUrl.Controllers
{
    public class UrlController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
