using System;
using System.Collections.Generic;
using System.Linq;
using static Address_Book.AddressBookMain;

namespace Address_Book
{
    public class ExistingContact
    {
        public static void Existing_Contact()
        {
            static void Main(string[] args)
            {
                // Create a new address book
                AddressBookMain addressBook = new AddressBookMain();

                // Add some contacts
                addressBook.AddContact(new CreateContact("John", "Doe", "123 Main St", "Anytown", "CA", "12345", "555-555-5555", "johndoe@email.com"));
                addressBook.AddContact(new CreateContact("Jane", "Doe", "456 Elm St", "Anytown", "CA", "12345", "555-555-5555", "janedoe@email.com"));

                // Display all contacts in the address book
                Console.WriteLine("All Contacts:");
                addressBook.PrintContacts();

                // Prompt the user to enter the first and last name of the contact to update
                Console.Write("Enter the first name of the contact to update: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter the last name of the contact to update: ");
                string lastName = Console.ReadLine();

                // Find the contact by name
                CreateContact contact = addressBook.FindContactByName(firstName, lastName);

                // If the contact is not found, display an error message and exit
                if (contact == null)
                {
                    Console.WriteLine("Contact not found.");
                    return;
                }

                // Prompt the user to update the contact's information
                Console.Write("Enter the new address: ");
                string address = Console.ReadLine();
                Console.Write("Enter the new city: ");
                string city = Console.ReadLine();
                Console.Write("Enter the new state: ");
                string state = Console.ReadLine();
                Console.Write("Enter the new zip code: ");
                string zip = Console.ReadLine();
                Console.Write("Enter the new phone number: ");
                string phoneNumber = Console.ReadLine();
                Console.Write("Enter the new email: ");
                string email = Console.ReadLine();

                // Update the contact's information
                contact.Address = address;
                contact.City = city;
                contact.State = state;
                contact.Zip = zip;
                contact.PhoneNumber = phoneNumber;
                contact.Email = email;

                // Display the updated contact information
                Console.WriteLine("Contact updated:");
                Console.WriteLine("Name: " + contact.FirstName + " " + contact.LastName);
                Console.WriteLine("Address: " + contact.Address);
                Console.WriteLine("City: " + contact.City);
                Console.WriteLine("State: " + contact.State);
                Console.WriteLine("Zip: " + contact.Zip);
                Console.WriteLine("Phone Number: " + contact.PhoneNumber);
                Console.WriteLine("Email: " + contact.Email);

                // Display all contacts in the address book after the update
                Console.WriteLine("All Contacts:");
                addressBook.PrintContacts();

                Console.ReadLine();
            }
        }
    

    }
}