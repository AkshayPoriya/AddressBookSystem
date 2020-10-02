using System;
using System.Collections.Generic;
using System.Text;

namespace _05_AddressBookSystem
{
    class AddressBook
    {
        private readonly NLog nLog = new NLog();
        public List<Contact> contactList = new List<Contact>();
        private Dictionary<string, Contact> nameToContactMapper = new Dictionary<string, Contact>();

        public void AddContacts()
        {
            bool flag = true;
            while (flag)
            {
                Contact contact = new Contact();
                if (contact.firstName == "" || contact.lastName == "" || contact.address == "" || contact.city == "" || contact.state == "" || contact.zip == "" || contact.phoneNumber == "" || contact.email == "")
                {
                    // Just to mark that this operation was unsuccessful
                    nLog.LogDebug("Debug Unsuccessful: AddContact()");
                    // Just to make a note that whatever values entered should be greater than zero
                    nLog.LogError("values entered by user was invalid i.e empty string");
                    // Just to make a note as a warning for values should not zero
                    nLog.LogWarn("Any entry should not be empty!");
                }
                contactList.Add(contact);
                nameToContactMapper.Add(contact.firstName + " " + contact.lastName, contact);
                Console.WriteLine("\nContact created successfully with following details: ");
                Console.WriteLine("FirstName: " + contact.firstName + "\nLast Name :" + contact.lastName);
                Console.WriteLine("Address: " + contact.address + "\nCity: " + contact.city);
                Console.WriteLine("State: " + contact.state + "\nZip: " + contact.zip);
                Console.WriteLine("Phone Number: " + contact.phoneNumber + "\nEmail: " + contact.email);

                nLog.LogDebug("Log Successful: AddContact()");
                // Just to mark a flag that this operation was successful
                nLog.LogInfo("Contact Created with first name: " + contact.firstName);

                Console.WriteLine("\nTo Add a New Contact Enter YES");
                string option = Console.ReadLine();
                if (option != "YES")
                {
                    flag = false;
                }
            }
        }

        public void EditDetails()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nTo modify details, enter firstname followed by a space, followed by lastname of the contact");
                string name = Console.ReadLine();
                if (nameToContactMapper.ContainsKey(name))
                {
                    Contact contact = nameToContactMapper[name];
                    Console.WriteLine("Enter Latest Details of Contact!");

                    Console.WriteLine("Enter First Name of Contact");
                    string firstName = Console.ReadLine();
                    contact.firstName = firstName;

                    Console.WriteLine("Enter Last Name of Contact");
                    string lastName = Console.ReadLine();
                    contact.lastName = lastName;

                    Console.WriteLine("Enter Address");
                    string address = Console.ReadLine();
                    contact.address = address;

                    Console.WriteLine("Enter City");
                    string city = Console.ReadLine();
                    contact.city = city;

                    Console.WriteLine("Enter state");
                    string state = Console.ReadLine();
                    contact.state = state;

                    Console.WriteLine("Enter zip");
                    string zip = Console.ReadLine();
                    contact.zip = zip;

                    Console.WriteLine("Enter Phone Number");
                    string phoneNumber = Console.ReadLine();
                    contact.phoneNumber = phoneNumber;

                    Console.WriteLine("Enter Email");
                    string email = Console.ReadLine();
                    contact.email = email;

                    Console.WriteLine("\nDetails modified successfully with following entries: ");
                    Console.WriteLine("FirstName: " + contact.firstName + "\nLast Name :" + contact.lastName);
                    Console.WriteLine("Address: " + contact.address + "\nCity: " + contact.city);
                    Console.WriteLine("State: " + contact.state + "\nZip: " + contact.zip);
                    Console.WriteLine("Phone Number: " + contact.phoneNumber + "\nEmail: " + contact.email);
                }
                else
                {
                    Console.WriteLine("Entered name did't match with any record!");
                }
                Console.WriteLine("\nTo update more contact details enter YES");
                string option = Console.ReadLine();
                if (option != "YES")
                    flag = false;
            }
        }
    }
}
