using Exercises.Models;
using System.Collections.Generic;

namespace Exercises.Services
{
    public class StudentServices
    {
        public List<StudentsModel> CreateStudentsFromFullNameList(List<string> stundentList)
        {
            List<StudentsModel> returnedList = new List<StudentsModel>();

            foreach(string student in stundentList)
            {
                string[] fullNameArray = student.Split(' ');
                int lastIndex = fullNameArray.Length - 1;
                string lastName = fullNameArray[lastIndex];

                StudentsModel studentToAdd = new StudentsModel
                {
                    FirstName = student.Replace(lastName, "").Trim(),
                    LastName = lastName
                };

                returnedList.Add(studentToAdd);
            }

            return returnedList;
        }
    }
}
