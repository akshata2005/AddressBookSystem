using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook");
            // Create a list of contacts.
            List<ContactDetails> contacts = new List<ContactDetails>();
            ContactDetails contact = new ContactDetails();

            //Add New Contact
            contact.AddNewContact();

            //Display entered contacts
            contact.DisplayContact();
        }
    }
}

