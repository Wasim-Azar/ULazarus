using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULazarusData.Models
{
    public class CourseResult
    {
        public int CourseResultId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; } = default!;
        public int CourseId { get; set; }
        public Course Course { get; set; } = default!;
        public decimal Score { get; set; }
    }
}
