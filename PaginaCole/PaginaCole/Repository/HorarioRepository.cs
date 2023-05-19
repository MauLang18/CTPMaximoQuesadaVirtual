using Microsoft.EntityFrameworkCore;
using PaginaCole.Interfaces;
using PaginaCole.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaginaCole.Repository
{
    public class HorarioRepository : IHorarioRepository
    {
        private readonly DBContext _context;

        public HorarioRepository(DBContext context)
        {
            _context = context;
        }
        public bool Add(HorarioDiario horario)
        {
            _context.Add(horario);
            return Save();
        }

        public bool Delete(HorarioDiario horario)
        {
            _context.Remove(horario);
            return Save();
        }

        public async Task<IEnumerable<HorarioDiario>> GetAll()
        {
            return await _context.HorariosDi.ToListAsync();
        }

        public async Task<HorarioDiario> GetByIdDAsync(int id)
        {
            return await _context.HorariosDi.FirstOrDefaultAsync(i => i.IDD == id);
        }

        public async Task<HorarioDiario> GetByIdSAsync(int id)
        {
            return await _context.HorariosDi.FirstOrDefaultAsync(i => i.IDS == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(HorarioDiario horario)
        {
            _context.Update(horario);
            return Save();
        }
    }
}
