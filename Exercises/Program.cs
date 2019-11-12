using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region exercitiu
            //numaram cate obiecte sunt in lista
            StudentsList studentsList = new StudentsList();
            List<string> returnedSudentList = studentsList.GetStudentList();
            Console.WriteLine("Students total count: {0}", returnedSudentList.Count);

            //imprimam lista
            foreach (string student in returnedSudentList)
            {
                Console.WriteLine(student);
            }

            //verificam cati studenti sunt cu numele 'Alex'
            foreach (string student in returnedSudentList)
            {
                if (student.ToLower().Contains("alex"))
                {
                    Console.WriteLine(student);
                }
            }
            #endregion

            #region tema
            
            #endregion
        }
    }
}
