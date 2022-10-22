using Microsoft.AspNetCore.Mvc;

namespace BlogSite2.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Blog()
        {
            return "Teresa May is back!";
        }
    }
}
