using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SofCaps.Models;
using SofCaps.Services;

namespace SofCaps.Controllers
{
    public class CapsController : Controller
    {
        private readonly ICapService _capService;
        private readonly ILogger<CapsController> _logger;

        public CapsController(ICapService capService, ILogger<CapsController> logger)
        {
            _capService = capService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var caps = _capService.GetAllCaps();
            return View(caps);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cap cap)
        {
            if (ModelState.IsValid)
            {
                _capService.AddCap(cap);
                _logger.LogInformation("Nueva gorra agregada: {Name}", cap.Name);
                return RedirectToAction("Index");
            }
            return View(cap);
        }
    }
}
