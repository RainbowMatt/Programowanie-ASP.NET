using Microsoft.AspNetCore.Mvc;
using Programowanie_ASP.NET.Models;

namespace Programowanie_ASP.NET.Controllers
{
    public class TravelController : Controller
    {
        static Dictionary<int, Travel> _travels = new Dictionary<int, Travel>();
        public IActionResult Index()
        {
            return View(_travels);
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
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (_travels.ContainsKey(id))
            {
                return View(_travels[id]);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Edit(Travel model)
        {
            if (ModelState.IsValid)
            {
                if (_travels.ContainsKey(model.Id))
                {
                    _travels[model.Id] = model;
                }

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (_travels.ContainsKey(id))
            {
                return View(_travels[id]);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Delete(Travel model)
        {
            if (_travels.ContainsKey(model.Id))
            {
                _travels.Remove(model.Id);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            if (_travels.ContainsKey(id))
            {
                return View(_travels[id]);
            }
            else
            {
                return NotFound();
            }
        }
    }
}

