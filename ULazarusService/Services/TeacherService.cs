using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULazarusData.Models;
using ULazarusData;
using ULazarusService.Interfaces;
using Microsoft.EntityFrameworkCore;


public class TeacherService : ITeacherService
{
    private readonly ULazarusContext _context;

    public TeacherService(ULazarusContext context) => _context = context;

    public async Task<List<Teacher>> GetAllAsync() => await _context.Teachers
        .Include(s => s.User)
        .Include(s => s.Courses)
        .ToListAsync();

    public async Task<Teacher?> GetByIdAsync(int id) => await _context.Teachers
        .Include(s => s.User)
        .Include(s => s.Courses)
        .FirstOrDefaultAsync(s => s.TeacherId == id);

    public async Task AddAsync(Teacher teacher)
    {
        _context.Teachers.Add(teacher);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Teacher teacher)
    {
        _context.Teachers.Update(teacher);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var teacher = await _context.Teachers.FindAsync(id);
        if (teacher != null)
        {
            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();
        }
    }
}

