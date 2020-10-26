using EllipticCurve.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Range(0, 4)]
        public float GPA { get; set; }

        [RegularExpression(@"u[0-9]{7}$", ErrorMessage = "Please use the format: u1234567")]
        public string UID { get; set; }

        [Range(0, 40)]
        public int HoursPerWeek { get; set; }

        [MaxLength(500, ErrorMessage = "Please limit your statement to 500 characters")]
        public string PersonalStatement { get; set; }

        public DateTime ApplicationDate { get; set; }

        public bool Active { get; set; }

        public ICollection<StudentSkill> Skills { get; set; }

        public ICollection<StudentInterest> Interests { get; set; }

        public ICollection<CompletedCourse> CompletedCourses { get; set; }
    }
}
