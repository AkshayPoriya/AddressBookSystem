using System;
using System.Collections.Generic;
using System.Text;

namespace _05_AddressBookSystem
{
    class AddressBook
    {
        private readonly NLog nLog = new NLog();
        public List<Contact> contactList = new List<Contact>();

        public void AddContact( )
        {
            Contact contact = new Contact();
            if (contact.firstName==""|| contact.lastName ==""|| contact.address ==""|| contact.city ==""|| contact.state ==""|| contact.zip ==""|| contact.phoneNumber ==""|| contact.email =="")
            {
                // Just to mark that this operation was unsuccessful
                nLog.LogDebug("Debug Unsuccessful: AddContact()");
                // Just to make a note that whatever values entered should be greater than zero
                nLog.LogError("values entered by user was invalid i.e empty string");
                // Just to make a note as a warning for values should not zero
                nLog.LogWarn("Any entry should not be empty!");
            }
            contactList.Add(contact);
            Console.WriteLine("Contact created successfully with following details: ");
            Console.WriteLine("FirstName: "+ contact.firstName +"\nLast Name :" + contact.lastName);
            Console.WriteLine("Address: "+contact.address + "\nCity: "+contact.city);
            Console.WriteLine("State: "+contact.state+ "\nZip: "+contact.zip);
            Console.WriteLine("Phone Number: "+contact.phoneNumber+"\nEmail: "+contact.email);

            nLog.LogDebug("Log Successful: AddContact()");
            // Just to mark a flag that this operation was successful
            nLog.LogInfo("Contact Created with first name: " + contact.firstName);
        }
    }
}
