using Microsoft.AspNetCore.Mvc;

namespace BlogSite2.Controllers
{
    public class TestController : Controller
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
