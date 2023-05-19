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
    public class NosotrosController : Controller
    {
        private readonly ILogger<NosotrosController> _logger;

        public NosotrosController(ILogger<NosotrosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Nosotros()
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
