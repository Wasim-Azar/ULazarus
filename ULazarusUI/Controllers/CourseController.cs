using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ULazarusData.Models;
using ULazarusService.Interfaces;

namespace ULazarusUI.Controllers
{
    public class CourseController : Controller
    {
        // Injecting the required services through constructor
        private readonly ICourseService _courseService;
        private readonly IFacultyService _facultyService;
        private readonly ISectorService _sectorService;
        private readonly ITeacherService _teacherService;

        public CourseController(
            ICourseService courseService,
            IFacultyService facultyService,
            ISectorService sectorService,
            ITeacherService teacherService)
        {
            _courseService = courseService;
            _facultyService = facultyService;
            _sectorService = sectorService;
            _teacherService = teacherService;
        }

        // GET: /Course
        // Publicly visible list of all courses
        // -------------------------
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var courses = await _courseService.GetAllAsync();
            return View(courses);
        }

        // GET: /Course/Details/5
        // View details of a specific course
        // -------------------------
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var course = await _courseService.GetByIdAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        // GET: /Course/Create
        // Show the form to create a new course
        // Only accessible to Admin or Teacher roles
        // -------------------------
        [Authorize(Roles = "Admin,Teacher")]
        public async Task<IActionResult> Create()
        {
            // Populate dropdown lists (faculties, sectors, teachers)
            await PopulateDropdownsAsync();
            return View(); // Return empty form
        }

        // POST: /Course/Create
        // Handle form submission to add a new course
        // -------------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Teacher")]
        public async Task<IActionResult> Create(Course course)
        {
            if (ModelState.IsValid)
            {
                await _courseService.AddAsync(course);
                return RedirectToAction(nameof(Index));
            }

            // If model state is invalid, reload dropdowns and return view
            ViewBag.Faculties = await _facultyService.GetAllAsync();
            ViewBag.Sectors = await _sectorService.GetAllAsync();
            ViewBag.Teachers = await _teacherService.GetAllAsync();
            return View(course);
        }

        // GET: /Course/Edit/5
        // Show the form to edit a course
        // -------------------------
        [Authorize(Roles = "Admin,Teacher")]
        public async Task<IActionResult> Edit(int id)
        {
            var course = await _courseService.GetByIdAsync(id);
            if (course == null)
            {
                return NotFound(); // Return 404 if course doesn't exist
            }

            // Populate dropdown lists
            await PopulateDropdownsAsync();

            return View(course); // Pass existing course to view for editing
        }

        // POST: /Course/Edit/5
        // Handle form submission to update a course
        // -------------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Teacher")]
        public async Task<IActionResult> Edit(int id, Course course)
        {
            if (id != course.CourseId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _courseService.UpdateAsync(course);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Faculties = await _facultyService.GetAllAsync();
            ViewBag.Sectors = await _sectorService.GetAllAsync();
            ViewBag.Teachers = await _teacherService.GetAllAsync();
            return View(course);
        }

        // GET: /Course/Delete/5
        // Show a confirmation page to delete a course
        // -------------------------
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var course = await _courseService.GetByIdAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: /Course/Delete/5
        // Confirm deletion of a course
        // -------------------------
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _courseService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

      

        // Private helper method to populate dropdowns for Create/Edit views
        // Converts Faculties, Sectors, Teachers to SelectListItem format
        // -------------------------
        private async Task PopulateDropdownsAsync()
        {
            // Faculties dropdown
            var faculties = await _facultyService.GetAllAsync();
            ViewBag.Faculties = faculties.Select(f => new SelectListItem
            {
                Value = f.FacultyId.ToString(),
                Text = f.Name
            });

            // Sectors dropdown
            var sectors = await _sectorService.GetAllAsync();
            ViewBag.Sectors = sectors.Select(s => new SelectListItem
            {
                Value = s.SectorId.ToString(),
                Text = s.Name
            });

            // Teachers dropdown
            var teachers = await _teacherService.GetAllAsync();
            ViewBag.Teachers = teachers.Select(t => new SelectListItem
            {
                Value = t.TeacherId.ToString(),
                Text = $"{t.FirstName} {t.LastName}" // Combine first and last name
            });
        }
    }

}

