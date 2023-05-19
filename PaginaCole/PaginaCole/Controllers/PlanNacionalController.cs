using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PaginaCole.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PaginaCole.Controllers
{
    public class PlanNacionalController : Controller
    {
        private readonly ILogger<PlanNacionalController> _logger;

        public PlanNacionalController(ILogger<PlanNacionalController> logger)
        {
            _logger = logger;
        }

        public IActionResult PlanNacional()
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
