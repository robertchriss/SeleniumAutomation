
using System;
using System.Collections.Generic;

namespace Exercises.Models
{
    public class CourseModel
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<StudentModel> Students { get; set; }
    }
}
