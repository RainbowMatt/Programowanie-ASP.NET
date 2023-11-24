using Microsoft.AspNetCore.Mvc;
using Programowanie_ASP.NET.Models;

namespace Programowanie_ASP.NET.Controllers
{
    public class TravelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Travel model)
        {
            if (ModelState.IsValid)
            {
                // Tutaj możesz umieścić kod do zapisu podróży do bazy danych lub innego rodzaju przechowywania danych
                // np. SaveTravelToDatabase(model);

                // Po zapisie możesz przekierować do widoku z listą podróży lub innych akcji
                // return RedirectToAction("Index");
            }

            // Jeśli ModelState.IsValid nie jest spełnione, powracamy do widoku z formularzem i błędami
            return View(model);
        }   
    }
}
