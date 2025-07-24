using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULazarusData.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        public string Email { get; set; }

        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public int? FacultyId { get; set; }
        public Faculty? Faculty { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
        
    }
}

