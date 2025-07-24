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
    public class FacultyService : IFacultyService
    {
        private readonly ULazarusContext _context;

        public FacultyService(ULazarusContext context) => _context = context;

        public async Task<List<Faculty>> GetAllAsync() =>
            await _context.Faculties.Include(f => f.Courses).ToListAsync();

        public async Task<Faculty?> GetByIdAsync(int id) =>
            await _context.Faculties.Include(f => f.Courses)
                                    .Include(f => f.Students)
                                    .Include(f => f.Teachers)
                                    .FirstOrDefaultAsync(f => f.FacultyId == id);

        public async Task AddAsync(Faculty faculty)
        {
            _context.Faculties.Add(faculty);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Faculty faculty)
        {
            _context.Faculties.Update(faculty);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var faculty = await _context.Faculties.FindAsync(id);
            if (faculty != null)
            {
                _context.Faculties.Remove(faculty);
                await _context.SaveChangesAsync();
            }
        }
    }
}
