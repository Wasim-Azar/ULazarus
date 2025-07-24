using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULazarusData.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }

        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; } 

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}

