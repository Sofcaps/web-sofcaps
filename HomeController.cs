using Microsoft.AspNetCore.Mvc;

namespace SofCaps.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
