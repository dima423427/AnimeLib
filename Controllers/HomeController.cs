using Microsoft.AspNetCore.Mvc;

namespace AnimeLib.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return PartialView();
        }
    }
}
