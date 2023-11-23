using Microsoft.AspNetCore.Mvc;
using Programowanie_ASP.NET.Models;
using System.Diagnostics;

namespace Programowanie_ASP.NET.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public enum Operator
        {
            Unknown, Add, Mul, Sub, Div
        }
        public IActionResult Calculator(Operator op, double? a, double? b) 
        {
            ViewBag.Op = op;
            ViewBag.A = a;
            ViewBag.B = b;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}