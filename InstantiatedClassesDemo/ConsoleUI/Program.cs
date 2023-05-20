namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We are using the blueprint here.
            // These are two different instances of the same model class PersonModel.
            // This allows us to save multiple data of the same variables together and they don't get mixed with one another.

            /*PersonModel person = new PersonModel();

            person.firstName = "Mus";

            PersonModel secondPerson = new PersonModel();

            secondPerson.firstName = "Mulan"
            
            Console.WriteLine(person.firstName);
            Console.WriteLine(secondPerson.firstName);
            
            */

            // Another efficient way of using this would be through a List.

            /*List<PersonModel> people = new List<PersonModel>();   

            PersonModel person = new PersonModel();
            person.firstName = "Mus";
            people.Add(person);

            person = new PersonModel();
            person.firstName = "Mulan";
            people.Add(person); 

            foreach (PersonModel p in people)
            {
                Console.WriteLine(p.firstName);
            }*/


            List<PersonModel> people = new List<PersonModel>();
            string firstName = "";
            

            do
            {
                Console.Write("What is your first name (or type exit): ");
                firstName = Console.ReadLine();

                Console.Write("What is your last name: ");
                string lastName = Console.ReadLine();

                if (firstName.ToLower() != "exit")
                {
                    PersonModel person = new PersonModel();
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    people.Add(person);
                }
            } while (firstName.ToLower() != "exit");

            foreach (PersonModel p in people) 
            {
                ProcessPerson.GreetPerson(p);
            }
            Console.ReadLine();
        }
    }
}

// Class instances will be used a lot for data and methods.
// Static classes are for stateless processing.
// This is in general, there are a few edge cases or exceptions to these rules.
