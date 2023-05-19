using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaginaCole.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        public DbSet<HorarioDiario> HorariosDi { get; set; }
    }

    public class HorarioDiario
    {
        public int ID { get; set; }
        public int IDD { get; set; }
        public string Fecha { get; set; }
        public string Imagen { get; set; }
        public string Grado { get; set; }

        public int IDS { get; set; }
        public string ImagenS { get; set; }
        public string Seccion { get; set; }
    }
}
