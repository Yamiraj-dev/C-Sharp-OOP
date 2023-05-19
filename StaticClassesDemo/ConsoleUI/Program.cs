namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = RequestData.GetAString("What is your first name: ");

            UserMessages.AppWelcomeMessage(firstName); // We reference the method by the class name first "UserMessages"

            double x = RequestData.GetADouble("Please enter your first number: ");
            double y = RequestData.GetADouble("Please enter your second number: ");

            double added = CalculateData.Add(x, y);
            double subtracted = CalculateData.Subtract(x, y);

            UserMessages.PrintResultMessage($"The sum of x and y is: {added}");
            UserMessages.PrintResultMessage($"The difference between x and y is {subtracted}");

            x = RequestData.GetADouble("Please enter a first number again: ");
            y = RequestData.GetADouble("Please enter a second number again: ");

            double multiplied = CalculateData.Multiply(x, y);
            double divided = CalculateData.Divide(x, y);

            UserMessages.PrintResultMessage($"The multiplication of x and y is: {multiplied}");
            UserMessages.PrintResultMessage($"The division of x and y is: {divided}");

            Console.ReadLine();
        }
    }
}

// We do not make all methods in one spot, especially in the program.cs file. 
// This goes back to the DRY principle.
// This method however dictates what the other methods should be doing, it doesn't do anything on its own in particular.
// It just calls other methods to do their jobs.
// If we add "static" parameter to our class, it does not allow us to create non-static methods.

// We do not typically store data in classes because it will be there for the entire life-time of the application. Which is bad as this takes up storage space. 

// We only make exceptions for when we want data to live for that life-time in the application. Such as a string that keeps the connection to the database.

// In summary, we use class files to separate code by logic, so that each of these classes and methods have a single purpose.