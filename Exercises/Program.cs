using System;
using System.Collections.Generic;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region exercitiu Week3, sesiunea 1
            //numaram cate obiecte sunt in lista
            StudentsList studentsList = new StudentsList();
            List<string> returnedStudentList = studentsList.GetStudentList();
            Console.WriteLine("Students total count: {0}", returnedStudentList.Count);

            //imprimam lista
            foreach (string student in returnedStudentList)
            {
                Console.WriteLine(student);
            }

            //verificam cati studenti sunt cu numele 'Alex'
            foreach (string student in returnedStudentList)
            {
                if (student.ToLower().Contains("alex"))
                {
                    Console.WriteLine(student);
                }
            }
            #endregion
        }
    }
}
