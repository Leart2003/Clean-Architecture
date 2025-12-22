using Microsoft.AspNetCore.Mvc;
using ShortUrl.Data.Models;

namespace ShortUrl.Controllers
{
    public class UrlController : Controller
    {
        public UrlController()
        {
                
        }
        

        public IActionResult Index()
        {

            Url urlDb = new Url()
            {
                Id = 1,
                OriginalLink = "https://www.google.com",
                ShortLink = "SHrotl",
                ClickedTime = 1,
                UserID = 1



            };

            var allData = new List<Url>();
            allData.Add(urlDb);

            ViewData["ShortenedURL"] = "This is just short Url";
            ViewData["AllUrls"] = new List<string>() {"url 1", "Url2"};

            
            return View(allData);
        }
    }
}
