using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPI.Models
{
    public class Instructor
    {
        public Guid InstructorID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }

        List<Course> Courses { get; set; } = new List<Course>();
    }
}