using System.Runtime.Intrinsics.Arm;

namespace MethodOverloadDemo
{

    // a big downside to method overloading is lots of repition, if you look down at how many constructors exist, it is repitive.
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel("Mus", "Gonzales");

            person.GenerateEmail("gmail.com", false);

            Console.WriteLine(person.Email);

            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public PersonModel()
        {
            // method overloading allows same method name but signature line must be different 
            // signature line is the name followed by what the method returns and its types
        }

        public PersonModel(string firstName, string lastName)
        {
            // this constructor is accepted because it only uses 2 strings instead of 3 in the next one, only types in parameters matter.
            FirstName = firstName;
            LastName = lastName;
        }
        public PersonModel(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void GenerateEmail()
        {
            GenerateEmail("aol.com", false);
        }

        public void GenerateEmail(string domain)
        {
            GenerateEmail(domain, false);
        }

        public void GenerateEmail(bool firstInitialMethod)
        {
            GenerateEmail("aol.com", firstInitialMethod);
        }

        public void GenerateEmail(string domain, bool firstInitialMethod)
        {
            if (firstInitialMethod == true)
            {
                Email = $"{FirstName.Substring(0, 1)}.{LastName}@{ domain }";
            }
            else
            {
                Email = $"{FirstName}.{LastName}@{ domain }";
            }
        }
    }
}
