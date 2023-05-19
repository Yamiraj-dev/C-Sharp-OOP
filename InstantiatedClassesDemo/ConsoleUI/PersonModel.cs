using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{

    // We can think of this model class as a blueprint.

    public class PersonModel
    {
        /*public string firstName;
        public string lastName;
        public string emailAddress;*/
        

        // Auto properties:
        // - type prop and hit tab twice
        // Naming is in Pascal case and not Camel case like previously shown above.

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool HasBeenGreeted { get; set; }
    }
}

// We should practice in general separating classes with data and those with methods.
// Very few instances static classes have data, and this is in an instantiated class.
// It holds up multiple pieces of data together, so they don't get mismatched for however long we need them to be around.
