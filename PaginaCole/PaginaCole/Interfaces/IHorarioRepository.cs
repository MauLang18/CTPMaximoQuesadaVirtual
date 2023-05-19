using PaginaCole.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PaginaCole.Interfaces
{
    public interface IHorarioRepository
    {
        Task<IEnumerable<HorarioDiario>> GetAll();
        Task<HorarioDiario> GetByIdDAsync(int id);
        Task<HorarioDiario> GetByIdSAsync(int id);
        bool Add(HorarioDiario horario);
        bool Update(HorarioDiario horario);
        bool Delete(HorarioDiario horario);
        bool Save();
    }
}
