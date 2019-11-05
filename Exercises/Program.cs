using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
        #region valueExemple

            int xCoord = 10;
            int yCoord = xCoord;

            xCoord = 12;

            Console.WriteLine("x is : " + xCoord);
            Console.WriteLine("Y is : " + yCoord);

        #endregion

        #region referenceExemple

            PersonModel person1 = new PersonModel();
            PersonModel person2 = new PersonModel();

            person1.age = 20;
            person1.name = "Maria";

            person2 = person1;

            person1.age = 25;

            Console.WriteLine("person1 age is : " + person1.age);
            Console.WriteLine("person2 age is : " + person2.age);

        #endregion
        }
    }
}
