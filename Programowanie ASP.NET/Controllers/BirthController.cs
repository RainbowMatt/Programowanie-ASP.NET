using Microsoft.AspNetCore.Mvc;
using Programowanie_ASP.NET.Models;

namespace Programowanie_ASP.NET.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Result(Birth model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
        public IActionResult Form()
        {
            return View();
        }
    }
}
