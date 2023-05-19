using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PaginaCole.Datos;
using PaginaCole.Interfaces;
using PaginaCole.Models;
using PaginaCole.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PaginaCole.Controllers
{
    public class HorariosController : Controller
    {
        HorariosDDatos _HorariosDDatos = new HorariosDDatos();
        private readonly IHorarioRepository _horarioRepository;
        private readonly IPhotoService _photoService;

        public HorariosController(IHorarioRepository horarioRepository, IPhotoService photoService)
        {
            _horarioRepository = horarioRepository;
            _photoService = photoService;
        }

        public IActionResult Detalle(int id)
        {
            var a = _HorariosDDatos.ObtenerHD(id);

            return View(a);
        }

        public IActionResult AgregarHD()
        {
            ViewBag.Grado = new List<string>() { "Septimo", "Octavo", "Noveno", "Decimo", "Undecimo", "Duodecimo" };
            ViewData["Mensaje"] = null;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AgregarHD(CreateHorarioViewModel HD)
        {
            if (ModelState.IsValid)
            {
                var result = await _photoService.AddPhotoAsyncHD(HD.Imagen);

                var horario = new HorarioDiario
                {
                    Fecha = HD.Fecha,
                    Grado = HD.Grado,
                    Imagen = result.Url.ToString()
                };
                _horarioRepository.Add(horario);
                return RedirectToAction("Horarios");
            }
            else
            {
                ModelState.AddModelError("", "Error al subir el horario");
            }

            return View(HD);
        }

        public IActionResult AgregarHS()
        {
            ViewBag.Seccion = new List<string>() { "7-1A", "7-1B", "7-2A", "7-2B", "7-3A", "7-3B", "7-4A", "7-4B", "7-5A", "7-5B", "7-6A", "7-6B", "8-1A", "8-1B", "8-2A", "8-2B", "8-3A", "8-3B", "8-4A", "8-4B", "8-5A", "8-5B", "8-6A", "8-6B", "9-1A", "9-1B", "9-2A", "9-2B", "9-3A", "9-3B", "9-4A", "9-4B", "9-5A", "9-5B", "9-6A", "9-6B", "9-1A", "10-1A", "10-1B", "10-2A", "10-2B", "10-3A", "10-3B", "10-4A", "10-4B", "11-1A", "11-1B", "11-2A", "11-2B", "11-3A", "11-3B", "11-4A", "11-4B", "12-1A", "12-1B", "12-2A", "12-2B", "12-3A", "12-3B", "12-4A", "12-4B" };
            ViewData["Mensaje"] = null;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AgregarHS(CreateHorarioViewModel HS)
        {
            if (ModelState.IsValid)
            {
                var result = await _photoService.AddPhotoAsyncHS(HS.ImagenS);

                var horario = new HorarioDiario
                {
                    Seccion = HS.Seccion,
                    ImagenS = result.Url.ToString()
                };
                var respuesta = _HorariosDDatos.GuardarHS(horario);

                if (respuesta)
                {
                    return RedirectToAction("Horarios");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("", "Error al subir el horario");
            }

            return View(HS);
        }

        public IActionResult ModificarHD(int id)
        {
            var a = _HorariosDDatos.ObtenerHD(id);
            var horario = new EditHorarioViewModel
            {
                ID = a.ID,
                Fecha = a.Fecha,
                Grado = a.Grado,
                URL = a.Imagen
            };
            ViewBag.Grado = new List<string>() { "Septimo", "Octavo", "Noveno", "Decimo", "Undecimo", "Duodecimo" };
            ViewData["Mensaje"] = null;

            return View(horario);
        }

        [HttpPost]
        public async Task<IActionResult> ModificarHD(EditHorarioViewModel HD)
        {
            if (ModelState.IsValid)
            {
                var a = _HorariosDDatos.ObtenerHD(HD.ID);

                if(a != null)
                {
                    try
                    {
                        await _photoService.DeletePhotoAsyncHD(a.Imagen);
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", "Error al eliminar la imagen");
                        return View(HD);
                    }
                }
                var result = await _photoService.AddPhotoAsyncHD(HD.Imagen);

                var horario = new HorarioDiario
                {
                    ID = HD.ID,
                    Fecha = HD.Fecha,
                    Grado = HD.Grado,
                    Imagen = result.Url.ToString()
                };
                var respuesta = _HorariosDDatos.ModificarHD(horario);

                if (respuesta)
                {
                    return RedirectToAction("Horarios");
                }
                else
                {
                    return View();
                }

                /*_horarioRepository.Update(horario);

                return RedirectToAction("Horarios");*/
            }
            else
            {
                ModelState.AddModelError("", "Error al modificar el horario");
            }

            return View(HD);
        }

        public IActionResult EliminarHD(int id)
        {
            var a = _HorariosDDatos.ObtenerHD(id);
            var horario = new EditHorarioViewModel
            {
                ID = a.ID,
                Fecha = a.Fecha,
                Grado = a.Grado,
                URL = a.Imagen
            };
            ViewBag.Grado = new List<string>() { "Septimo", "Octavo", "Noveno", "Decimo", "Undecimo", "Duodecimo" };
            ViewData["Mensaje"] = null;

            return View(horario);
        }

        [HttpPost]
        public async Task<IActionResult> EliminarHD(EditHorarioViewModel HD)
        {
            if (ModelState.IsValid)
            {
                var a = _HorariosDDatos.ObtenerHD(HD.ID);

                if (a != null)
                {
                    try
                    {
                        await _photoService.DeletePhotoAsyncHD(a.Imagen);
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("", "Error al eliminar la imagen");
                        return View(HD);
                    }
                }

                var horario = new HorarioDiario
                {
                    ID = HD.ID,
                };
                var respuesta = _HorariosDDatos.EliminarHD(horario);

                if (respuesta)
                {
                    return RedirectToAction("Horarios");
                }
                else
                {
                    return View();
                }

                /*_horarioRepository.Update(horario);

                return RedirectToAction("Horarios");*/
            }
            else
            {
                ModelState.AddModelError("", "Error al eliminar el horario");
            }

            return View(HD);
        }

        public IActionResult Horarios()
        {
            var horario = _HorariosDDatos.ListarHorariosD();

            return View(horario); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
