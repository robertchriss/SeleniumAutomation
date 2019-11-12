using System;

namespace Exercises.SessionExcerises
{
    public static class LeapYearCalculator
    {
        public static void VerifyLeapYear()
        {
            Console.WriteLine("Enter year:");

            var isNumber = int.TryParse(Console.ReadLine(), out int enteredYear);

            if (!isNumber)
            {
                Console.WriteLine("The entered value is not a number");
                Environment.Exit(0);
            }

            var isLeapYear = IsLeapYear(enteredYear);

            if (isLeapYear)
            {
                Console.WriteLine("Year {0} is a leap year", enteredYear);
            }
            else
            {
                Console.WriteLine("Year {0} is not a leap year", enteredYear);
            }
        }

        public static bool IsLeapYear(int givenYear)
        {
            if (givenYear % 4 == 0)
            {
                if (givenYear % 100 == 0 && givenYear % 400 != 0)
                {
                    return false;
                }

                return true;
            }

            return false;
        }
    }
}
