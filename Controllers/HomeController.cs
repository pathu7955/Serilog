using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SerilogDemo.Controllers
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
            _logger.LogInformation("LogInformation log");
            _logger.LogDebug("Log Debug");
            _logger.LogWarning("Log Warning");
            _logger.LogError("Log Error");
            _logger.LogCritical("Log Critical");
            return View();
        }
    }
}