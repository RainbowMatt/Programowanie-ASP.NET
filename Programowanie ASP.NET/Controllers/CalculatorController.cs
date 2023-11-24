using Microsoft.AspNetCore.Mvc;
using Programowanie_ASP.NET.Models;
using static Programowanie_ASP.NET.Controllers.HomeController;

namespace Programowanie_ASP.NET.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Result(Calculator model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
        /*public enum Operator
        {
            Unknown, Add, Mul, Sub, Div
        }
        public IActionResult Result(Operator op, double? a, double? b)
        {
            double result = 0;
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
        }*/
        public IActionResult Form()
        {
            return View();
        }
    }
}
