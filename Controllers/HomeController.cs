using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ShortUrl.Data.ViewModel;


namespace ShortUrl.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            PostUrlVm newUrl =  new PostUrlVm();
            return View(newUrl);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Remove(int linkToRemove)
        {
            return View();
        }

        public IActionResult ShortenUrl(PostUrlVm postUrlVm)
        {
            if (ModelState.IsValid)
            {
                return View("Index", postUrlVm);
            }
            return View("Index");
        }

    }
}
