using Exercises.Models;
using System;

namespace Exercises.Services
{
    public class TeacherService
    {
        public void CalculateTeachingExperience(TeacherModel teacher, int beginTeachingYear)
        {
            if (beginTeachingYear <= DateTime.Now.Year)
            {
                teacher.TeachingExperience = DateTime.Now.Year - beginTeachingYear;
            }
            else
            {
                throw new ArgumentException("The year you've entered is not valid: "+ beginTeachingYear);
            }
        }
    }
}
