using DemoLibrary;

namespace AccessModifiersDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            /*DataAccess data = new DataAccess();*/ // inaccessible to internal class

            person.SavePerson();

            Console.WriteLine("Hello, World!");
        }
    }

    public class ModifiedDataAccess : DataAccess
    {
        public void GetUnsecureConnectionInfo()
        {
            GetConnectionString(); // still gains access to this method as you inherit from a protected internal method.
        }
    }

    public class CEO : Manager
    {
        public void GetConnectionInfo()
        {
           ModifiedDataAccess modifiedDataAccess = new ModifiedDataAccess();

            modifiedDataAccess.GetUnsecureConnectionInfo(); // now we can accesss something internal even though this class does not inherit from DataAccess, we call the method that does.
            
            formerLastName = "accessible";
        }
    }
}