using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULazarusData.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; } = default!;
        public int? FacultyId { get; set; }
        public Faculty? Faculty { get; set; }
        public int? SectorId { get; set; }
        public Sector? Sector { get; set; }
        public int? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public ICollection<CourseResult> CourseResults { get; set; } = new List<CourseResult>();
        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
    }
      
};

