using Exercises.Services;
using Exercises.SessionExcerises;
using System.Collections.Generic;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetingHelper greetingHelper = new GreetingHelper();
            GreetingHelper.GetGreetingMessage("Nume");
        }
    }
}
