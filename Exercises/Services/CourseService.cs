
using Exercises.Models;
using System;
using System.Collections.Generic;

namespace Exercises.Services
{
    public class CourseService
    {
        public void AddStudentsToCourse(CourseModel course, List<StudentModel> students)
        {
            if (course == null || course.Students == null)
            {
                throw new Exception("Course or Students cannot be null");
            }

            course.Students.AddRange(students);
        }

        public void ModifyCourseDates(CourseModel course, DateTime startDate, DateTime endDate)
        {
            if (course == null)
            {
                throw new Exception("Course cannot be null");
            }

            course.StartDate = startDate;
            course.EndDate = endDate;
        }
    }
}
