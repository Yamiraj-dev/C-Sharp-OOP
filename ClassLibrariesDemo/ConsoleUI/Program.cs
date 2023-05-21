using DemoLibrary.Models;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We cannot call any related items in DemoLibrary because it is a separate project and has no relationship with ConsoleUI
            // We have to add a project reference to DemoLibrary in this case

            // The same cannot be done to DemoLibrary by adding a project reference to ConsoleUI, this causes a circular dependency
            // So building the ConsoleUI project depends on DemoLibrary being finished, but if referenced it back, it would say well it can't be built because ConsoleUI depends on DemoLibrary being finished and this would loop indefinitely.

            PersonModel person = new PersonModel();

            Console.ReadLine();
        }
    }
}

// Learning C# we should primarily store most of our code in class libraries. User interface is interchangeable once you have a class library set up.
// You cannot start a Class Library directly. We need a user interface to run it.