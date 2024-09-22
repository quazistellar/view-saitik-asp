using Microsoft.AspNetCore.Mvc;
using practa1hz.Models;
using System.Diagnostics;

namespace practa1hz.Controllers
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

        public IActionResult Ctlg()
        {
            return View();
        }
        public IActionResult Fav()
        {
            return View();
        }

        public IActionResult Ord()
        {
            return View();
        }

        public IActionResult Crt()
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
