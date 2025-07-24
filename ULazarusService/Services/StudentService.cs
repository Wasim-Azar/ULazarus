using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULazarusData.Models;
using ULazarusData;
using ULazarusService.Interfaces;
using Microsoft.EntityFrameworkCore;


public class StudentService : IStudentService
{
    private readonly ULazarusContext _context;

    public StudentService(ULazarusContext context) => _context = context;

    public async Task<List<Student>> GetAllAsync() => await _context.Students
        .Include(s => s.User)
        .Include(s => s.CourseResults)
        .ToListAsync();

    public async Task<Student?> GetByIdAsync(int id) => await _context.Students
        .Include(s => s.User)
        .Include(s => s.CourseResults)
        .FirstOrDefaultAsync(s => s.StudentId == id);

    public async Task AddAsync(Student student)
    {
        _context.Students.Add(student);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Student student)
    {
        _context.Students.Update(student);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student != null)
        {
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }
    }
}

