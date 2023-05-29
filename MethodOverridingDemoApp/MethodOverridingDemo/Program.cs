namespace MethodOverridingDemo
{
    internal class Program
    {

        // if changing a method happens very often then go with an abstract class
        // if changing a method happens only sometimes or when only needed, then virtual is a good choice

        static void Main(string[] args)
        {
            PersonModel person = new PersonModel()
            {
                FirstName = "Mus",
                LastName = "Gonzales",
                Email = "Yamiraj.dev@gmail.com"
            };

            Console.WriteLine(person);
            Console.ReadLine();
        }
    }
}