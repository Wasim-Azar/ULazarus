using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ULazarusData;
using ULazarusData.Models;
using ULazarusService.Interfaces;
using System.Threading.Tasks;

namespace ULazarusUI.Controllers
{
    // Only logged-in users can access this controller by default
    [Authorize]
    public class StudentController : Controller
    {
        private readonly ULazarusContext _context;          // For accessing faculties and schedules
        private readonly IStudentService _studentService;   // For student-related data operations

        public StudentController(ULazarusContext context, IStudentService studentService)
        {
            _context = context;
            _studentService = studentService;
        }

        // -------------------------
        // GET: /Student
        // Visible to everyone (anonymous access allowed)
        // -------------------------
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var students = await _studentService.GetAllAsync();
            return View(students);
        }

        // -------------------------
        // GET: /Student/Details/5
        // Visible to Admin, Teacher, or the student who owns the profile
        // -------------------------
        [Authorize(Roles = "Admin,Teacher,Student")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _studentService.GetByIdAsync(id.Value);
            if (student == null)
                return NotFound();

            // Students can only view their own profile
            if (User.IsInRole("Student") && User.Identity!.Name != student.User.Email)
                return Forbid();

            return View(student);
        }

        // -------------------------
        // GET: /Student/Create
        // Only Admins and Teachers can create students
        // -------------------------
        [Authorize(Roles = "Admin,Teacher")]
        public IActionResult Create()
        {
            // Populate dropdowns for Faculty and Schedule
            ViewData["FacultyId"] = new SelectList(_context.Faculties, "Id", "Name");
            ViewData["ScheduleId"] = new SelectList(_context.Schedules, "Id", "Location");
            return View();
        }

        // -------------------------
        // POST: /Student/Create
        // Handles form submission to create a student
        // -------------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Teacher")]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Email,FacultyId,ScheduleId")] Student student)
        {
            if (ModelState.IsValid)
            {
                await _studentService.AddAsync(student);
                return RedirectToAction(nameof(Index));
            }

            // If form validation fails, reload dropdowns and return form
            ViewData["FacultyId"] = new SelectList(_context.Faculties, "Id", "Name", student.FacultyId);
            ViewData["ScheduleId"] = new SelectList(_context.Schedules, "Id", "Location", student.ScheduleId);
            return View(student);
        }

        // -------------------------
        // GET: /Student/Edit/5
        // Only Admins and Teachers can edit student data
        // -------------------------
        [Authorize(Roles = "Admin,Teacher")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _studentService.GetByIdAsync(id.Value);
            if (student == null)
                return NotFound();

            // Populate dropdowns with selected values
            ViewData["FacultyId"] = new SelectList(_context.Faculties, "Id", "Name", student.FacultyId);
            ViewData["ScheduleId"] = new SelectList(_context.Schedules, "Id", "Location", student.ScheduleId);
            return View(student);
        }

        // -------------------------
        // POST: /Student/Edit/5
        // Handles form submission to edit student
        // -------------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Teacher")]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,FirstName,LastName,Email,FacultyId,ScheduleId")] Student student)
        {
            if (id != student.StudentId)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    await _studentService.UpdateAsync(student);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await StudentExists(student.StudentId))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }

            // If form validation fails, reload dropdowns and return form
            ViewData["FacultyId"] = new SelectList(_context.Faculties, "Id", "Name", student.FacultyId);
            ViewData["ScheduleId"] = new SelectList(_context.Schedules, "Id", "Location", student.ScheduleId);
            return View(student);
        }

        // -------------------------
        // GET: /Student/Delete/5
        // Only Admins can delete students
        // -------------------------
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _studentService.GetByIdAsync(id.Value);
            if (student == null)
                return NotFound();

            return View(student);
        }

        // -------------------------
        // POST: /Student/Delete/5
        // Handles form submission to confirm delete
        // -------------------------
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _studentService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        // -------------------------
        // Helper method to check if student exists
        // -------------------------
        private async Task<bool> StudentExists(int id)
        {
            var student = await _studentService.GetByIdAsync(id);
            return student != null;
        }
    }
}
