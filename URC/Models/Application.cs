using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URC.Models
{
    public class Application
    {

        public int ID { get; set; }

        public string Email { get; set; }

        public string Resume { get; set; }

        public DateTime ExpectedGradDate { get; set; }

        public string DegreePlan { get; set; }

        public float GPA { get; set; }

        public string UID { get; set; }

        public int HoursPerWeek { get; set; }

        public string PersonalStatement { get; set; }

        public DateTime ApplicationDate { get; set; }

        public bool Active { get; set; }

        public ICollection<StudentSkill> Skills { get; set; }

        public ICollection<StudentInterest> Interests { get; set; }

        public ICollection<CompletedCourse> CompletedCourses { get; set; }
    }
}
