// Get information of each guest (at least one guest and max is unknown)
// Info to get: First name, last name, message to the host
// Once done, loop through each guest and print their info

// Design the UI content in the UI and leave everything else in the class library.

using GuestBookLibrary.Models;

namespace ConsoleUI
{
    internal class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>(); // notice variable name is plural as this list multiple guests
        // also notice how this is a private static variable as it lives outside the method and is only for use within this class.

        static void Main(string[] args)
        {
           
            
            GetGuestInfo();
            PrintGuestInfo();
            
            Console.ReadLine();
        }

        private static void PrintGuestInfo()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }

        private static void GetGuestInfo()
        {
            string moreGuests = "";

            do
            {
                GuestModel guest = new GuestModel(); // notice variable name is singular as this will hold a single entry for a guest 

                
                guest.FirstName = GetInfoFromConsole("What is your first name: ");

          
                guest.LastName = GetInfoFromConsole("What is your last name: ");

                
                guest.MessageToHost = GetInfoFromConsole("What message would you like to send to the host: ");

                
                moreGuests = GetInfoFromConsole("Are more guests coming (yes/no): ");

                guests.Add(guest); // add the guest to the guests list

                Console.Clear(); // Clear previous guest information

            } while (moreGuests.ToLower() == "yes");
        }

        private static string GetInfoFromConsole(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }
    }
}