using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PaginaCole.Datos;
using PaginaCole.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PaginaCole.Controllers
{
    public class LoginController : Controller
    {
        RegistroEDatos _RegistroEDatos = new RegistroEDatos();
        RegistroDDatos _RegistroDDatos = new RegistroDDatos();
        RegistroADatos _RegistroADatos = new RegistroADatos();
        ValidacionDatos _ValidacionDatos = new ValidacionDatos();
        LoginDatos _LoginDatos = new LoginDatos();
        PerfilDatos _PerfilDatos = new PerfilDatos();

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login oLogin)
        {
            var a = _LoginDatos.UsuariosE(oLogin.Cedula, oLogin.User, oLogin.Pass);
            var b = _LoginDatos.UsuariosD(oLogin.Cedula, oLogin.User, oLogin.Pass);
            var c = _LoginDatos.UsuariosA(oLogin.Cedula, oLogin.User, oLogin.Pass);
            var d = _LoginDatos.UsuariosC(oLogin.Cedula, oLogin.User, oLogin.Pass);

            if (a.Id != 1)
            {
                var oPerfil = _PerfilDatos.DatosE(oLogin.Cedula);
                HttpContext.Session.SetString("Username", oPerfil.User);
                HttpContext.Session.SetString("Cedula", oPerfil.Cedula);
                HttpContext.Session.SetString("Seccion", oPerfil.Seccion);
                HttpContext.Session.SetString("Rango", oPerfil.Rango);
                return RedirectToAction("Index", "Home");
            }
            else if (b.Id != 1)
            {
                var oPerfil = _PerfilDatos.DatosD(oLogin.Cedula);
                HttpContext.Session.SetString("Username", oPerfil.User);
                HttpContext.Session.SetString("Cedula", oPerfil.Cedula);
                HttpContext.Session.SetString("Rango", oPerfil.Rango);
                return RedirectToAction("Index", "Home");
            }
            else if (c.Id != 1)
            {
                var oPerfil = _PerfilDatos.DatosA(oLogin.Cedula);
                HttpContext.Session.SetString("Username", oPerfil.User);
                HttpContext.Session.SetString("Cedula", oPerfil.Cedula);
                HttpContext.Session.SetString("Rango", oPerfil.Rango);
                return RedirectToAction("Index", "Home");
            }
            else if (d.Id != 1)
            {
                var oPerfil = _PerfilDatos.DatosC(oLogin.Cedula);
                HttpContext.Session.SetString("Username", oPerfil.User);
                HttpContext.Session.SetString("Cedula", oPerfil.Cedula);
                HttpContext.Session.SetString("Rango", oPerfil.Rango);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewData["Mensaje"] = "usuario no encontrado";
                return View();
            }
        }

        public IActionResult Register()
        {
            ViewBag.Rango = new List<string>() { "Estudiante", "Docente", "Administrativo" };
            ViewData["Mensaje"] = null;

            return View();
        }

        [HttpPost]
        public IActionResult Register(Registros oRegistros)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            ViewBag.Rango = new List<string>() { "Estudiante", "Docente", "Administrativo" };

            if (oRegistros.Rango == "Estudiante")
            {
                var a = _ValidacionDatos.CedE(oRegistros.Cedula);

                if (a.Cedula != "0")
                {
                    var aa = _ValidacionDatos.UserE(oRegistros.Cedula);

                    if (aa.Cedula == "0")
                    {
                        var respuesta = _RegistroEDatos.GuardarE(oRegistros);

                        if (respuesta)
                        {
                            return RedirectToAction("Login");
                        }
                        else
                        {
                            return View();
                        }
                    }
                    else
                    {
                        ViewData["Mensaje"] = "Ya se creo una cuenta con ese numero de cedula";
                        return View();
                    } 
                }
                else
                {
                    ViewData["Mensaje"] = "La cedula no está registrada";
                    return View();
                }
            }
            else if (oRegistros.Rango == "Docente")
            {
                var a = _ValidacionDatos.CedD(oRegistros.Cedula);

                if (a.Cedula != "0")
                {
                    var aa = _ValidacionDatos.UserD(oRegistros.Cedula);

                    if (aa.Cedula == "0")
                    {
                        var respuesta = _RegistroDDatos.GuardarD(oRegistros);

                        if (respuesta)
                        {
                            return RedirectToAction("Login");
                        }
                        else
                        {
                            return View();
                        }
                    }
                    else
                    {
                        ViewData["Mensaje"] = "Ya se creo una cuenta con ese numero de cedula";
                        return View();
                    }
                }
                else
                {
                    ViewData["Mensaje"] = "La cedula no está registrada";
                    return View();
                }
            }
            else if (oRegistros.Rango == "Administrativo")
            {
                var a = _ValidacionDatos.CedA(oRegistros.Cedula);

                if (a.Cedula != "0")
                {
                    var aa = _ValidacionDatos.UserA(oRegistros.Cedula);

                    if (aa.Cedula == "0")
                    {
                        var respuesta = _RegistroADatos.GuardarA(oRegistros);

                        if (respuesta)
                        {
                            return RedirectToAction("Login");
                        }
                        else
                        {
                            return View();
                        }
                    }
                    else
                    {
                        ViewData["Mensaje"] = "Ya se creo una cuenta con ese numero de cedula";
                        return View();
                    }
                }
                else
                {
                    ViewData["Mensaje"] = "La cedula no está registrada";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Cerrar()
        {
            HttpContext.Session.SetString("Username", "0");
            HttpContext.Session.SetString("Cedula", "0");
            HttpContext.Session.SetString("Seccion", "0");
            HttpContext.Session.SetString("Rango", "0");

            return RedirectToAction("Login");
        }

        public IActionResult Modificar(string Cedula)
        {
            var a = _RegistroEDatos.ObtenerE(Cedula);
            var b = _RegistroDDatos.ObtenerD(Cedula);
            var c = _RegistroADatos.ObtenerA(Cedula);

            if (a.Id != 1)
            {
                return View(a);
            }
            else if (b.Id != 1)
            {
                return View(b);
            }
            else if (c.Id != 1)
            {
                return View(c);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Modificar(Registros oRegistros)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var a = _RegistroEDatos.ObtenerEE(oRegistros.Cedula);
            var b = _RegistroDDatos.ObtenerDD(oRegistros.Cedula);
            var c = _RegistroADatos.ObtenerAA(oRegistros.Cedula);

            if (a.Id != 1)
            {
                var respuesta = _RegistroEDatos.EditarE(oRegistros);

                if (respuesta)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    return View();
                }
            }
            else if (b.Id != 1)
            {
                var respuesta = _RegistroDDatos.EditarD(oRegistros);

                if (respuesta)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    return View();
                }
            }
            else if (c.Id != 1)
            {
                var respuesta = _RegistroADatos.EditarA(oRegistros);

                if (respuesta)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar(string Cedula)
        {
            var a = _RegistroEDatos.ObtenerE(Cedula);
            var b = _RegistroDDatos.ObtenerD(Cedula);
            var c = _RegistroADatos.ObtenerA(Cedula);

            if (a.Id != 1)
            {
                return View(a);
            }
            else if (b.Id != 1)
            {
                return View(b);
            }
            else if (c.Id != 1)
            {
                return View(c);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Eliminar(Registros oRegistros)
        {
            var a = _RegistroEDatos.ObtenerEE(oRegistros.Cedula);
            var b = _RegistroDDatos.ObtenerDD(oRegistros.Cedula);
            var c = _RegistroADatos.ObtenerAA(oRegistros.Cedula);

            if (a.Id != 1)
            {
                var respuesta = _RegistroEDatos.EliminarE(oRegistros.Cedula);

                if (respuesta)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    return View();
                }
            }
            else if (b.Id != 1)
            {
                var respuesta = _RegistroDDatos.EliminarD(oRegistros.Cedula);

                if (respuesta)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    return View();
                }
            }
            else if (c.Id != 1)
            {
                var respuesta = _RegistroADatos.EliminarA(oRegistros.Cedula);

                if (respuesta)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public IActionResult Preguntas()
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
