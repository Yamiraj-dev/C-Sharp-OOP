using ConsoleUI.Models;
using FoundationInfo; // since we changed the namespace of Calculations to FoundationInfo, we need to state that here for our Calculations methods

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.
            List<PersonModel> people = new List<PersonModel>(); // This List is in the System.Collections.Generic Namespace

            Console.WriteLine();

            PersonModel person = new PersonModel();

            /*ConsoleUI.*/
            Calculations.Add(4,3); // ConsoleUI is the Namespace which is why we don't actually need to type out ConsoleUI
            Console.ReadLine();

        }
    }
}

// Namespsaces allow us to separate things further by being in a different namespace. As we usually just separate data and methods and classes, namespaces can help us do this more.
// In here the default Namespace is ConsoleUI and that can be changed in the project properties.
// We do not typically rename Namespaces to organize things, instead we move these items to folders.
// If we look into models, the namespace there is ConsoleUI.Models