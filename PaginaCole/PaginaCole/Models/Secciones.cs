using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaginaCole.Models
{
    public class Secciones
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe llenar el campo de cedula")]
        public string Cedula { get; set; }
        public string Seccion { get; set; }
    }
}
