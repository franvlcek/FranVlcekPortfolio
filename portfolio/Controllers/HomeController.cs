using Microsoft.AspNetCore.Mvc;
using portfolio.Models;
using System.Diagnostics;

namespace portfolio.Controllers
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
            return View();
        }
        public IActionResult Education()
        {
            return View();
        }
        public IActionResult Employment()
        {
            return View();
        }
        public IActionResult Certificates()
        {
            return View();
        }
        public IActionResult MyProjects()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
