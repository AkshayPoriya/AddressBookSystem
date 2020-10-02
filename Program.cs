using System;

namespace _05_AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program!");
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact();
        }
    }
}
