using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Add Person :");
            int num = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            while (x <= num)
            {
                AddressBookMain.AddPerson();               //adding a person count
                x++;
            }
            AddressBookMain.ShowPeople();

        }
    }
}
