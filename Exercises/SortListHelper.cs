using System.Collections.Generic;

namespace Exercises
{
    public class SortListHelper
    {
        public List<int> BubbleSortList(List<int> numberList)
        {
            int temp;

            for (int i = 0; i < numberList.Count-1; i++)
            {
                for (int j = 0; j < numberList.Count-1; j++)
                {
                    if (numberList[j] > numberList[j+1])
                    {
                        temp = numberList[j + 1];
                        numberList[j + 1] = numberList[j];
                        numberList[j] = temp;
                    }
                }
            }

            return numberList;
        }
    }
}
