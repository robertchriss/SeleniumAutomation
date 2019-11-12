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
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SortListHelper sortListHelper = new SortListHelper();
            List<int> bubbleList = new List<int> { 800, 11, 50, 771, 649, 770, 240, 9, 100, 33, 245, 3454, 78, 03, 34 };
            sortListHelper.BubbleSortList(bubbleList);
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: " + stopwatch.Elapsed);

            stopwatch.Reset();
            stopwatch.Start();
            List<int> numberList = new List<int> { 800, 11, 50, 771, 649, 770, 240, 9, 100, 33, 245, 3454, 78, 03, 34 };
            numberList.Sort();
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: " + stopwatch.Elapsed);
            #endregion
        }
    }
}
