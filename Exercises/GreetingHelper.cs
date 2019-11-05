using System;

namespace Exercises
{
    public class GreetingHelper
    {
        public static string GetGreetingMessage(string name)
        {
            return "Hi " + name + "!";
        }

        public static void WelcomeUser()
        {
            Console.WriteLine("Enter name");
            var name = Console.ReadLine();
            var message = GetGreetingMessage(name);
            Console.WriteLine(message);
        }
    }
}
