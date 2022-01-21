using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook
{
    class AddressBookMain
    {
        /// <summary>
        /// Addresses the book.
        /// </summary>
       
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string PhoneNumber { get; set; }
        private string[] Addresses { get; set; }

        public static List<AddressBookMain> persons = new List<AddressBookMain>();
        // creating list  to store the all address of persons

        public static void AddPerson()  //creating metod for a class
        {
            AddressBookMain person = new AddressBookMain(); // creating a object for to access instance method or variable

            Console.Write("Enter First Name: "); // Taking the inputs from user
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            string[] addressArray = new string[2]; // creating Array  to store the address
            Console.Write("Enter Address 1: ");
            addressArray[0] = Console.ReadLine();
            Console.Write("Enter Address 2 (Optional): ");
            addressArray[1] = Console.ReadLine();
            person.Addresses = addressArray;

            persons.Add(person);
        }
        /// <summary>
        /// Displaying the Welcome message 
        /// </summary>
        private static void PrintPerson(AddressBookMain person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address 1: " + person.Addresses[0]);
            Console.WriteLine("Address 2: " + person.Addresses[1]);
            Console.WriteLine("-------------------------------------------");
        }
        public static void ShowPeople() //This method used to show people who are present in Address book
        {
            if (persons.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");

            foreach (var Element in persons)
            {
                PrintPerson(Element);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
        public static void RemovePerson() //this method for remove the people with respect their names
        {
            Console.WriteLine("Enter the first name of the person you would like to remove.");
            string firstName = Console.ReadLine();
            AddressBookMain person = persons.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());

            if (person == null)
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
            PrintPerson(person);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                persons.Remove(person);
                Console.WriteLine("Person removed. Press any key to continue.");
                Console.ReadKey();
            }
            Console.Read();
        }

    }


}
