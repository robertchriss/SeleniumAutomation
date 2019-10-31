using System;

namespace Exercises
{
    public static class MathOperations
    {
        public static int GetSum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static void AddTwoNumbers()
        {
            Console.WriteLine("Enter 1st test number:");
            var isNumber1 = int.TryParse(Console.ReadLine(), out int firstNumber);
            CheckIsNumeric(isNumber1);

            Console.WriteLine("Enter 2nd number:");
            var isNumber2 = int.TryParse(Console.ReadLine(), out int secondNumber);
            CheckIsNumeric(isNumber2);

            int sum = GetSum(firstNumber, secondNumber);

            Console.WriteLine("The sum is: " + sum);
            Console.ReadLine();
        }

        static void CheckIsNumeric(bool isNumeric)
        {
            if (!isNumeric)
            {
                Console.WriteLine("You did not entered a number");
                System.Threading.Thread.Sleep(2000);
                Environment.Exit(0);
            }
        }
    }
}
