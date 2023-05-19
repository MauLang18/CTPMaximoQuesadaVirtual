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
    public class DatabaseController : Controller
    {
        EstudiantesDatos _EstudiantesDatos = new EstudiantesDatos();
        DocentesDatos _DocentesDatos = new DocentesDatos();
        AdministrativosDatos _AdministrativosDatos = new AdministrativosDatos();
        ExtraDatos _ExtraDatos = new ExtraDatos();
        SeccionesDatos _SeccionesDatos = new SeccionesDatos();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListaE()
        {
            var oEst = _EstudiantesDatos.ListarE();

            return View(oEst);
        }

        public IActionResult GuardarE()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GuardarE(Estudiantes oEst)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _EstudiantesDatos.GuardarE(oEst);

            if (respuesta)
            {
                return RedirectToAction("ListaE");
            }
            else
            {
                return View();
            }
        }

        public IActionResult ModificarE(string Cedula)
        {
            var a = _EstudiantesDatos.ObtenerE(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult ModificarE(Estudiantes oEst)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _EstudiantesDatos.EditarE(oEst);

            if (respuesta)
            {
                return RedirectToAction("ListaE");
            }
            else
            {
                return View();
            }
        }

        public IActionResult EliminarE(string Cedula)
        {
            var a = _EstudiantesDatos.ObtenerE(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult EliminarE(Estudiantes oEst)
        {
            var respuesta = _EstudiantesDatos.EliminarE(oEst);

            if (respuesta)
            {
                return RedirectToAction("ListaE");
            }
            else
            {
                return View();
            }
        }

        public IActionResult ListaD()
        {
            var oDoc = _DocentesDatos.ListarD();

            return View(oDoc);
        }

        public IActionResult GuardarD()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GuardarD(Docentes oDoc)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _DocentesDatos.GuardarD(oDoc);

            if (respuesta)
            {
                return RedirectToAction("ListaD");
            }
            else
            {
                return View();
            }
        }

        public IActionResult ModificarD(string Cedula)
        {
            var a = _DocentesDatos.ObtenerD(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult ModificarD(Docentes oDoc)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _DocentesDatos.EditarD(oDoc);

            if (respuesta)
            {
                return RedirectToAction("ListaD");
            }
            else
            {
                return View();
            }
        }

        public IActionResult EliminarD(string Cedula)
        {
            var a = _DocentesDatos.ObtenerD(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult EliminarD(Docentes oDoc)
        {
            var respuesta = _DocentesDatos.EliminarD(oDoc);

            if (respuesta)
            {
                return RedirectToAction("ListaD");
            }
            else
            {
                return View();
            }
        }

        public IActionResult ListaA()
        {
            var oAdm = _AdministrativosDatos.ListarA();

            return View(oAdm);
        }

        public IActionResult GuardarA()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GuardarA(Administrativos oAdm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _AdministrativosDatos.GuardarA(oAdm);

            if (respuesta)
            {
                return RedirectToAction("ListaA");
            }
            else
            {
                return View();
            }
        }

        public IActionResult ModificarA(string Cedula)
        {
            var a = _AdministrativosDatos.ObtenerA(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult ModificarA(Administrativos oAdm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _AdministrativosDatos.EditarA(oAdm);

            if (respuesta)
            {
                return RedirectToAction("ListaA");
            }
            else
            {
                return View();
            }
        }

        public IActionResult EliminarA(string Cedula)
        {
            var a = _AdministrativosDatos.ObtenerA(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult EliminarA(Administrativos oAdm)
        {
            var respuesta = _AdministrativosDatos.EliminarA(oAdm);

            if (respuesta)
            {
                return RedirectToAction("ListaA");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Cambio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CambioA()
        {
            var respuesta = _ExtraDatos.Cambio();

            if (respuesta)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult EliminarCuentaE()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EliminarCuentaE(Estudiantes oEst)
        {
            var respuesta = _ExtraDatos.FueraE(oEst);

            if (respuesta)
            {
                return RedirectToAction("ListaE");
            }
            else
            {
                return View();
            }
        }

        public IActionResult EliminarCuentaD()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EliminarCuentaD(Docentes oDoc)
        {
            var respuesta = _ExtraDatos.FueraD(oDoc);

            if (respuesta)
            {
                return RedirectToAction("ListaD");
            }
            else
            {
                return View();
            }
        }

        public IActionResult EliminarCuentaA()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EliminarCuentaA(Administrativos oAdm)
        {
            var respuesta = _ExtraDatos.FueraA(oAdm);

            if (respuesta)
            {
                return RedirectToAction("ListaA");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista7_1()
        {
            var oSec = _SeccionesDatos.Listar7_1();

            return View(oSec);
        }

        public IActionResult Guardar7_1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar7_1(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar7_1(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista7_1");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar7_1(string Cedula)
        {
            var a = _SeccionesDatos.Obtener7_1(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar7_1(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar7_1(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista7_1");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista7_2()
        {
            var oSec = _SeccionesDatos.Listar7_2();

            return View(oSec);
        }

        public IActionResult Guardar7_2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar7_2(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar7_2(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista7_2");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar7_2(string Cedula)
        {
            var a = _SeccionesDatos.Obtener7_2(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar7_2(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar7_2(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista7_2");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista7_3()
        {
            var oSec = _SeccionesDatos.Listar7_3();

            return View(oSec);
        }

        public IActionResult Guardar7_3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar7_3(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar7_3(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista7_3");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar7_3(string Cedula)
        {
            var a = _SeccionesDatos.Obtener7_3(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar7_3(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar7_3(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista7_3");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista7_4()
        {
            var oSec = _SeccionesDatos.Listar7_4();

            return View(oSec);
        }

        public IActionResult Guardar7_4()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar7_4(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar7_4(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista7_4");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar7_4(string Cedula)
        {
            var a = _SeccionesDatos.Obtener7_4(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar7_4(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar7_4(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista7_4");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista7_5()
        {
            var oSec = _SeccionesDatos.Listar7_5();

            return View(oSec);
        }

        public IActionResult Guardar7_5()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar7_5(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar7_5(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista7_5");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar7_5(string Cedula)
        {
            var a = _SeccionesDatos.Obtener7_5(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar7_5(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar7_5(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista7_5");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista7_6()
        {
            var oSec = _SeccionesDatos.Listar7_6();

            return View(oSec);
        }

        public IActionResult Guardar7_6()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar7_6(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar7_6(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista7_6");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar7_6(string Cedula)
        {
            var a = _SeccionesDatos.Obtener7_6(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar7_6(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar7_6(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista7_6");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista8_1()
        {
            var oSec = _SeccionesDatos.Listar8_1();

            return View(oSec);
        }

        public IActionResult Guardar8_1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar8_1(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar8_1(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista8_1");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar8_1(string Cedula)
        {
            var a = _SeccionesDatos.Obtener8_1(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar8_1(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar8_1(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista8_1");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista8_2()
        {
            var oSec = _SeccionesDatos.Listar8_2();

            return View(oSec);
        }

        public IActionResult Guardar8_2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar8_2(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar8_2(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista8_2");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar8_2(string Cedula)
        {
            var a = _SeccionesDatos.Obtener8_2(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar8_2(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar8_2(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista8_2");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista8_3()
        {
            var oSec = _SeccionesDatos.Listar8_3();

            return View(oSec);
        }

        public IActionResult Guardar8_3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar8_3(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar8_3(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista8_3");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar8_3(string Cedula)
        {
            var a = _SeccionesDatos.Obtener8_3(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar8_3(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar8_3(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista8_3");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista8_4()
        {
            var oSec = _SeccionesDatos.Listar8_4();

            return View(oSec);
        }

        public IActionResult Guardar8_4()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar8_4(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar8_4(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista8_4");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar8_4(string Cedula)
        {
            var a = _SeccionesDatos.Obtener8_4(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar8_4(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar8_4(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista8_4");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista8_5()
        {
            var oSec = _SeccionesDatos.Listar8_5();

            return View(oSec);
        }

        public IActionResult Guardar8_5()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar8_5(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar8_5(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista8_5");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar8_5(string Cedula)
        {
            var a = _SeccionesDatos.Obtener8_5(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar8_5(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar8_5(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista8_5");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista8_6()
        {
            var oSec = _SeccionesDatos.Listar8_6();

            return View(oSec);
        }

        public IActionResult Guardar8_6()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar8_6(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar8_6(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista8_6");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar8_6(string Cedula)
        {
            var a = _SeccionesDatos.Obtener8_6(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar8_6(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar8_6(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista8_6");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista9_1()
        {
            var oSec = _SeccionesDatos.Listar9_1();

            return View(oSec);
        }

        public IActionResult Guardar9_1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar9_1(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar9_1(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista9_1");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar9_1(string Cedula)
        {
            var a = _SeccionesDatos.Obtener9_1(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar9_1(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar9_1(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista9_1");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista9_2()
        {
            var oSec = _SeccionesDatos.Listar9_2();

            return View(oSec);
        }

        public IActionResult Guardar9_2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar9_2(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar9_2(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista9_2");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar9_2(string Cedula)
        {
            var a = _SeccionesDatos.Obtener9_2(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar9_2(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar9_2(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista9_2");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista9_3()
        {
            var oSec = _SeccionesDatos.Listar9_3();

            return View(oSec);
        }

        public IActionResult Guardar9_3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar9_3(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar9_3(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista9_3");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar9_3(string Cedula)
        {
            var a = _SeccionesDatos.Obtener9_3(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar9_3(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar9_3(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista9_3");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista9_4()
        {
            var oSec = _SeccionesDatos.Listar9_4();

            return View(oSec);
        }

        public IActionResult Guardar9_4()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar9_4(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar9_4(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista9_4");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar9_4(string Cedula)
        {
            var a = _SeccionesDatos.Obtener9_4(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar9_4(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar9_4(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista9_4");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista9_5()
        {
            var oSec = _SeccionesDatos.Listar9_5();

            return View(oSec);
        }

        public IActionResult Guardar9_5()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar9_5(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar9_5(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista9_5");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar9_5(string Cedula)
        {
            var a = _SeccionesDatos.Obtener9_5(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar9_5(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar9_5(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista9_5");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista9_6()
        {
            var oSec = _SeccionesDatos.Listar9_6();

            return View(oSec);
        }

        public IActionResult Guardar9_6()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar9_6(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar9_6(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista9_6");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar9_6(string Cedula)
        {
            var a = _SeccionesDatos.Obtener9_6(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar9_6(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar9_6(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista9_6");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista10_1()
        {
            var oSec = _SeccionesDatos.Listar10_1();

            return View(oSec);
        }

        public IActionResult Guardar10_1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar10_1(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar10_1(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista10_1");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar10_1(string Cedula)
        {
            var a = _SeccionesDatos.Obtener10_1(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar10_1(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar10_1(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista10_1");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista10_2()
        {
            var oSec = _SeccionesDatos.Listar10_2();

            return View(oSec);
        }

        public IActionResult Guardar10_2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar10_2(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar10_2(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista10_2");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar10_2(string Cedula)
        {
            var a = _SeccionesDatos.Obtener10_2(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar10_2(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar10_2(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista10_2");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista10_3()
        {
            var oSec = _SeccionesDatos.Listar10_3();

            return View(oSec);
        }

        public IActionResult Guardar10_3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar10_3(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar10_3(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista10_3");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar10_3(string Cedula)
        {
            var a = _SeccionesDatos.Obtener10_3(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar10_3(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar10_3(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista10_3");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista10_4()
        {
            var oSec = _SeccionesDatos.Listar10_4();

            return View(oSec);
        }

        public IActionResult Guardar10_4()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar10_4(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar10_4(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista10_4");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar10_4(string Cedula)
        {
            var a = _SeccionesDatos.Obtener10_4(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar10_4(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar10_4(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista10_4");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista11_1()
        {
            var oSec = _SeccionesDatos.Listar11_1();

            return View(oSec);
        }

        public IActionResult Guardar11_1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar11_1(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar11_1(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista11_1");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar11_1(string Cedula)
        {
            var a = _SeccionesDatos.Obtener11_1(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar11_1(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar11_1(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista11_1");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista11_2()
        {
            var oSec = _SeccionesDatos.Listar11_2();

            return View(oSec);
        }

        public IActionResult Guardar11_2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar11_2(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar11_2(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista11_2");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar11_2(string Cedula)
        {
            var a = _SeccionesDatos.Obtener11_2(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar11_2(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar11_2(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista11_2");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista11_3()
        {
            var oSec = _SeccionesDatos.Listar11_3();

            return View(oSec);
        }

        public IActionResult Guardar11_3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar11_3(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar11_3(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista11_3");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar11_3(string Cedula)
        {
            var a = _SeccionesDatos.Obtener11_3(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar11_3(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar11_3(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista9_3");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista11_4()
        {
            var oSec = _SeccionesDatos.Listar11_4();

            return View(oSec);
        }

        public IActionResult Guardar11_4()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar11_4(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar11_4(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista11_4");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar11_4(string Cedula)
        {
            var a = _SeccionesDatos.Obtener11_4(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar11_4(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar11_4(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista11_4");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista12_1()
        {
            var oSec = _SeccionesDatos.Listar12_1();

            return View(oSec);
        }

        public IActionResult Guardar12_1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar12_1(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar12_1(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista12_1");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar12_1(string Cedula)
        {
            var a = _SeccionesDatos.Obtener12_1(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar12_1(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar12_1(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista12_1");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista12_2()
        {
            var oSec = _SeccionesDatos.Listar12_2();

            return View(oSec);
        }

        public IActionResult Guardar12_2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar12_2(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar12_2(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista12_2");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar12_2(string Cedula)
        {
            var a = _SeccionesDatos.Obtener12_2(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar12_2(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar12_2(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista12_2");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista12_3()
        {
            var oSec = _SeccionesDatos.Listar12_3();

            return View(oSec);
        }

        public IActionResult Guardar12_3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar12_3(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar12_3(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista12_3");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar12_3(string Cedula)
        {
            var a = _SeccionesDatos.Obtener12_3(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar12_3(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar12_3(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista12_3");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Lista12_4()
        {
            var oSec = _SeccionesDatos.Listar12_4();

            return View(oSec);
        }

        public IActionResult Guardar12_4()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar12_4(Secciones oSec)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var respuesta = _SeccionesDatos.Guardar12_4(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista12_4");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Eliminar12_4(string Cedula)
        {
            var a = _SeccionesDatos.Obtener12_4(Cedula);

            return View(a);
        }

        [HttpPost]
        public IActionResult Eliminar12_4(Secciones oSec)
        {
            var respuesta = _SeccionesDatos.Eliminar12_4(oSec);

            if (respuesta)
            {
                return RedirectToAction("Lista12_4");
            }
            else
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
