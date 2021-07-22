using Calculator.WebPresentation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.WebPresentation.Controllers
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

        public IActionResult CalculatorPage(string arg1, string arg2, string math)
        {
            double a = 0;
            double b = 0;
            string res = "";

            if(double.TryParse(arg1, out a) && double.TryParse(arg2, out b))
            {
                res += a + b;
            }

            return View(model: res);
        }

        public IActionResult Calculate(string arg1, string arg2, string math)
        {
            return View("CalculatorPage", model: 100);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
