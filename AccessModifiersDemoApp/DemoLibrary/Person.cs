using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// internal allows anything in this assembly to talk to DataAccess, but nothing outside.
// most common access modifiers are public and private

namespace DemoLibrary
{
    public class DataAccess 
    {
        protected internal string GetConnectionString()
        {
            return "Sensitive Data";
        }
    }

    public class Person
    {

        private protected string formerLastName = ""; // the protected allows us access as long as it derives from it (child class/inheritance), or within the same class.

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private string _ssn;

        public string SSN
        {
            get 
            { 
                return $"***-**-{_ssn.Substring(_ssn.Length - 4)}"; 
            }
            set 
            {
                _ssn = value; 
            }
        }

        public void ChangeLastName(string newLastName)
        {
            formerLastName = newLastName;
            LastName = newLastName;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello {FirstName}");
        }

        public void SavePerson()
        {
            DataAccess data = new DataAccess();
            string conn = data.GetConnectionString();
            // save person data
        }
    }

    public class Employee : Person
    {
        public string GetFormerLastName()
        {
            return formerLastName;
        }
    }

    public class Manager : Person
    {
        public string GetFormerLastName()
        {
            return formerLastName;
        }
    }
}
