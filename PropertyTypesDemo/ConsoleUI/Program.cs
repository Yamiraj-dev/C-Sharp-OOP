namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel(); // so we pass that string here in the constructor instead

            // Now this makes sure we have the minimum amount of data to start with. Here it would be ridiculous to hard code everyone's last name to be the same. But we can apply this so several other edge cases/scenarios.

            person.FirstName = "Mus";
           // person.LastName = "Gonzales"; we cannot pass this now as it is a private set
            person.Age = 25;
            person.SSN = "123-45-6789";

            Console.WriteLine(person.FullName);
            Console.WriteLine(person.SSN);

            Console.ReadLine();
        }
    }
}