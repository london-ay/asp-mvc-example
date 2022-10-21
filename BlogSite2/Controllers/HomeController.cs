using Microsoft.AspNetCore.Mvc;

namespace BlogSite2.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "home";
        }

        public string Blog() 
        {
            return "Teresa May is back!";
        }
    }
}
