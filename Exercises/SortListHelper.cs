using System.Collections.Generic;

namespace Exercises
{
    public class SortListHelper
    {
        public List<int> BubbleSortList(List<int> numberList)
        {
            int temp;

            for (int i = 0; i < numberList.Count; i++)
            {
                for (int j = i + 1; j < numberList.Count; j++)
                {
                    if (numberList[i] > numberList[j])
                    {
                        temp = numberList[i];

                        numberList[i] = numberList[j];

                        numberList[j] = temp;
                    }
                }
            }

            return numberList;
        }
    }
}
