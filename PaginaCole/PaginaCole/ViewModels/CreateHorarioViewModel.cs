using Microsoft.AspNetCore.Http;

namespace PaginaCole.ViewModels
{
    public class CreateHorarioViewModel
    {
        public string Fecha { get; set; }
        public IFormFile Imagen { get; set; }
        public string Grado { get; set; }

        public IFormFile ImagenS { get; set; }
        public string Seccion { get; set; }
    }
}
