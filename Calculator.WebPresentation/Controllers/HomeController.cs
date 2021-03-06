using Calculator.WebPresentation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Calculator.BusinessLogic;

namespace Calculator.WebPresentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IViewServices _viewServices;
        private readonly List<string> _result;

        public HomeController(ILogger<HomeController> logger, IViewServices viewServices)
        {
            _logger = logger;
            _viewServices = viewServices;
            _result = _viewServices.Load();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CalculatorPage(string fnum, string snum, string operation)
        {
            string res = "";
            double num1;
            double num2;
            if(Double.TryParse(fnum, out num1) && Double.TryParse(snum, out num2) && !String.IsNullOrEmpty(operation))
            {
                res += _viewServices.FindRes(num1, num2, operation);
                _result.Add(res);
                _viewServices.Save(_result);
            }          

            return View(model: _result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
