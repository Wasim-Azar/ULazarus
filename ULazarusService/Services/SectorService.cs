using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULazarusData.Models;
using ULazarusData;
using ULazarusService.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ULazarusService.Services
{
    public class SectorService : ISectorService
    {
        private readonly ULazarusContext _context;

        public SectorService(ULazarusContext context) => _context = context;

        public async Task<List<Sector>> GetAllAsync() =>
            await _context.Sectors.Include(s => s.Courses).ToListAsync();

        public async Task<Sector?> GetByIdAsync(int id) =>
            await _context.Sectors.Include(s => s.Courses)
                                  .FirstOrDefaultAsync(s => s.SectorId == id);

        public async Task AddAsync(Sector sector)
        {
            _context.Sectors.Add(sector);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Sector sector)
        {
            _context.Sectors.Update(sector);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var sector = await _context.Sectors.FindAsync(id);
            if (sector != null)
            {
                _context.Sectors.Remove(sector);
                await _context.SaveChangesAsync();
            }
        }
    }
}
