using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a command : 1 = add,2 = remove,3 = list");

            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    AddressBookMain.AddPerson();
                    break;
                case 2:
                    AddressBookMain.RemovePerson();
                    break;
                case 3:
                    AddressBookMain.ShowPeople();
                    break;
            }
            Console.Read();
        }

    }
}

