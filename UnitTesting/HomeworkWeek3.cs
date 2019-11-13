using Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTesting
{
    [TestClass]
    public class HomeworkWeek3
    {
        List<int> bubbleList = new List<int> { 800, 11, 50, 771, 649, 770, 240, 9, 100, 33, 245, 3454, 78, 03, 34 };
        List<int> numberList = new List<int> { 800, 11, 50, 771, 649, 770, 240, 9, 100, 33, 245, 3454, 78, 03, 34 };

        [TestMethod]
        public void BubbleSortList_IsSlowerThanDefaultSorting()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SortListHelper sortListHelper = new SortListHelper();
            sortListHelper.BubbleSortList(bubbleList);
            stopwatch.Stop();
            var bubbleSortingTime = stopwatch.Elapsed.Ticks;

            stopwatch.Reset();
            stopwatch.Start();
            numberList.Sort();
            stopwatch.Stop();
            var defaultSortingTime = stopwatch.Elapsed.Ticks;

            Assert.IsTrue(bubbleSortingTime > defaultSortingTime);
        }

        [TestMethod]
        public void BubbleSortList_Returns_SameResultAsDefaultSorting()
        {
            SortListHelper sortListHelper = new SortListHelper();

            sortListHelper.BubbleSortList(bubbleList);
            numberList.Sort();

            Assert.IsTrue(AreListEqual(bubbleList, numberList));
        }

        private bool AreListEqual(List<int> firstList, List<int> secondList)
        {
            if (firstList.Count == secondList.Count)
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    if (firstList[i] != secondList[i])
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }
    }
}
