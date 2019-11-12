using System;

namespace Exercises.SessionExcerises
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
