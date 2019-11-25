using Exercises.Models;
using System;

namespace Exercises.Services
{
    public class TeacherService
    {
        public void CalculateTeachingExperience(TeacherModel teacher, int beginTeachingYear)
        {
            teacher.TeachingExperience = DateTime.Now.Year - beginTeachingYear;
        }
    }
}
