using Microsoft.AspNetCore.Mvc;
using MVS.Models;
using System.Diagnostics;

namespace MVS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Model_View_Controller()
        {
            return View();
        }

        public IActionResult Model()
        {
            return View();
        }

        public IActionResult ViewInform()
        {
            return View();
        }
        public IActionResult Controller()
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