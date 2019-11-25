using System.Collections.Generic;

namespace Exercises.Models
{
    public class TeacherModel
    {
        public string FullName { get; set; }

        public int TeachingExperience { get; set; }

        public List<CourseModel> ListOfCourses { get; set; }
    }
}
