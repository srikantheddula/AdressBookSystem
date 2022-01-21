using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
     class AddressBookMain
    {
        /// <summary>
        /// Addresses the book.
        /// </summary>
        public static void AddressBook() //creating Static Method
        {
            Console.Write("Enter First Name: "); 
            Console.ReadLine();
            Console.Write("Enter Last Name: ");
            Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            Console.ReadLine();
            
            string[] addressArray = new string[2]; // creating Array  to store the address
            Console.Write("Enter Address 1: ");
            addressArray[0] = Console.ReadLine();
            Console.Write("Enter Address 2 (Optional): ");
            addressArray[1] = Console.ReadLine();

            foreach (string element in addressArray)    //print  the addressArray
            {
                Console.WriteLine(element);

            }

        }
    }
}
