using Exercises.Models;
using System.Collections.Generic;

namespace Exercises.Services
{
    public class StudentServices
    {
        public List<StudentModel> CreateStudentsFromFullNameList(List<string> stundentList)
        {
            List<StudentModel> returnedList = new List<StudentModel>();

            foreach(string student in stundentList)
            {
                string[] fullNameArray = student.Split(' ');
                int lastIndex = fullNameArray.Length - 1;
                string lastName = fullNameArray[lastIndex];

                StudentModel studentToAdd = new StudentModel
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
