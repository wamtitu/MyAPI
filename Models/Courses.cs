using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPI.Models
{
    public class Course
    {
        public Guid CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; } = 0;

        public Instructor Instructor { get; set; }
        public Guid InstructorID { get; set; }
    }
}