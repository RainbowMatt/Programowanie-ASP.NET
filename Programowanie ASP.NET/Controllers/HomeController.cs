﻿using Microsoft.AspNetCore.Mvc;
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
            double result = 0 ;
            if (a == null || b == null || op == Operator.Unknown)
            {
                ViewBag.Op = Operator.Unknown;
                ViewBag.A = null;
                ViewBag.B = null;
                return View();
            }
            
            switch (op)
            {
                case Operator.Add:
                    result = a.Value + b.Value;
                    break;
                case Operator.Sub:
                    result = a.Value - b.Value;
                    break;
                case Operator.Mul:
                    result = a.Value * b.Value;
                    break;
                case Operator.Div:
                    if (b.Value != 0)
                    {
                        result = a.Value / b.Value;
                    }
                    else
                    {
                        b = null;
                    }
                    break;
            }
            ViewBag.Op = op;
            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.Result = result;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}