using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonModel
    {
        public string FirstName { private get; set; } // We can set private to a get or set depending on the scenario. Private get does not allow us to read the value from outside and private set does not allow us to set the value from outside this property.
        public string LastName { get; private set; }
        // public int Age { get; set; }

        private string _password;

        public string Password
        {
            // We remove the get as we will not show the password.
            set 
            { 
                _password = value; 
            }
        }

        public string FullName // This property takes values from multiple areas appending them together into one property.
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }

        

        // Below is the same line of code as above but a full property.
        private int _age; // this is called a private backing field, which in standards starts off with an underscore "_" followed by CamelCase.
        // We should not manipulate the variable directly, but only within the property itself.

        public int Age
        {
            get 
            { 
                return _age; 
            }
            set 
            { 
                if (value >= 0 && value < 100)
                {
                    _age = value; // When it gets data it is assigned to a special variable valled value and in get this is returned.
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age needs to be within a valid range.");
                }
            }
        }

        // public string SSN { get; set; } // Social Security Number

        private string _ssn;

        public string SSN
        {
            get 
            { 
                // 123-45-6789 -> 11 - 7 = 4
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 4);
                return output; 
            }
            set 
            {
                _ssn = value; 
            }
        }

        // Since we cannot ask the user for a last name, we can user a special method called a constructor
        public PersonModel(string lastName)
        {
            LastName = lastName;
        }

        // method overloading
        public PersonModel()
        {
            // This allows us to pass PersonModel without anything being placed in, so even without a last name in this context.
        }
    }
}

// Properties allows us to expand get and set. This protects the data type and if it is a valid entry.
// In general instead of using full properties (fullprop) we are more generally inclined to use auto properties (prop). Because not everything has a special case.
// So by default, we use auto properties and then move to full properties only when necessary.
