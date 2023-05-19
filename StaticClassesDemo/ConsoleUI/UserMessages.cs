using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    // access modifier should be set to public 
    public static class UserMessages
    {
        public static void AppWelcomeMessage(string firstName)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Static Classes Demo App");

            int hourOfDay = DateTime.Now.Hour;

            if (hourOfDay < 12)
            {
                Console.WriteLine($"Good morning {firstName}!");
            }
            else if (hourOfDay < 19)
            {
                Console.WriteLine($"Good afternoon {firstName}!");
            }
            else
            {
                Console.WriteLine($"Good evening {firstName}!");
            }
        }   

        public static void PrintResultMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Thank you for using our app to calculate for you.");
            Console.WriteLine();

        }
    }
}

// We should keep the filename and classname the same to be organised.