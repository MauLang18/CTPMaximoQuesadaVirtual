using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MimeKit;
using MimeKit.Text;
using PaginaCole.Interfaces;
using PaginaCole.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PaginaCole.Controllers
{
    public class ContactoController : Controller
    {
        private readonly IEmailService _emailService;

        public ContactoController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public IActionResult Contacto()
        {
            return View();
        } 

        [HttpPost]
        public IActionResult SendEmail(EmailDto request)
        {
            request.Body2 = "Nombre: " + request.Name + " \nCorreo: " + request.Email + " \n" + request.Body;
            _emailService.SendEmail(request);
            System.Diagnostics.Debug.WriteLine(request.Body2);
            return RedirectToAction("Contacto");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
