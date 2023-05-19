using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaginaCole.Models
{
    public class Registros
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe llenar el campo de usuario")]
        public string User { get; set; }
        [Required(ErrorMessage = "Debe llenar el campo de contraseña")]
        public string Pass { get; set; }
        [Required(ErrorMessage = "Debe llenar el campo de cedula")]
        public string Cedula { get; set; }

        public string Rango { get; set; }

        public int Mensaje { get; set; }
    }
}
