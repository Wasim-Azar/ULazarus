using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULazarusData.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;

        
        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }

        // Add Faculty and Schedule relations:
        public int? FacultyId { get; set; }
        public Faculty? Faculty { get; set; }

        public int? ScheduleId { get; set; }
        public Schedule? Schedule { get; set; }

        public ICollection<CourseResult> CourseResults { get; set; } = new List<CourseResult>();
    }
}



