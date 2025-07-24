using Microsoft.EntityFrameworkCore;
using ULazarusData;
using ULazarusData.Models;
using ULazarusService.Interfaces;

namespace ULazarusService.Services
{
    public class CourseService : ICourseService
    {
        private readonly ULazarusContext _context;

        public CourseService(ULazarusContext context) => _context = context;

        public async Task<List<Course>> GetAllAsync() => await _context.Courses
            .Include(c => c.Faculty).Include(c => c.Sector).Include(c => c.Teacher)
            .ToListAsync();

        public async Task<Course?> GetByIdAsync(int id) => await _context.Courses
            .Include(c => c.Faculty).Include(c => c.Sector).Include(c => c.Teacher).Include(c => c.Schedules)
            .FirstOrDefaultAsync(c => c.CourseId == id);

        public async Task AddAsync(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Course course)
        {
            _context.Courses.Update(course);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                await _context.SaveChangesAsync();
            }
        }
    }
}
