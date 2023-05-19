using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaginaCole.Models
{
    public class Docentes
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe llenar el campo de usuario")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe llenar el campo de contraseña")]
        public string Apellido1 { get; set; }
        [Required(ErrorMessage = "Debe llenar el campo de contraseña")]
        public string Apellido2 { get; set; }
        [Required(ErrorMessage = "Debe llenar el campo de cedula")]
        public string Cedula { get; set; }
    }
}
