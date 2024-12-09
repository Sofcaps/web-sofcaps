using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SofCaps.Controllers
{
    public class GorrasController : Controller
    {
        private readonly ILogger<GorrasController> _logger;

        public GorrasController(ILogger<GorrasController> logger)
        {
            _logger = logger;
        }

        // Acción para la página principal de gorras
        public IActionResult Index()
        {
            _logger.LogInformation("Acceso a la página principal de gorras.");
            return View();
        }

        // Acción para mostrar las gorras 9FIFTY
        public IActionResult NineFifty()
        {
            _logger.LogInformation("Acceso a la página de gorras 9FIFTY.");
            return View();
        }

        // Acción para mostrar las gorras 59FIFTY
        public IActionResult FiftyNineFifty()
        {
            _logger.LogInformation("Acceso a la página de gorras 59FIFTY.");
            return View();
        }

        // Acción para mostrar las gorras 9FORTY
        public IActionResult NineForty()
        {
            _logger.LogInformation("Acceso a la página de gorras 9FORTY.");
            return View();
        }

        // Acción para mostrar las gorras BUCKETS
        public IActionResult Buckets()
        {
            _logger.LogInformation("Acceso a la página de gorras BUCKETS.");
            return View();
        }
    }
}
