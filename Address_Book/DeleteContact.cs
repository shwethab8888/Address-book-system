using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Address_Book.AddressBookMain;

namespace Address_Book
{
    public class DeleteContact
    {
        public static void Delete_Contact()
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

                // Prompt the user to enter the first and last name of the contact to delete
                Console.Write("Enter the first name of the contact to delete: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter the last name of the contact to delete: ");
                string lastName = Console.ReadLine();

                // Find the contact by name
                CreateContact contact = addressBook.FindContactByName(firstName, lastName);

                // If the contact is not found, display an error message and exit
                if (contact == null)
                {
                    Console.WriteLine("Contact not found.");
                    return;
                }

                // Remove the contact from the address book
                addressBook.RemoveContact(contact);

                // Display a message indicating that the contact has been deleted
                Console.WriteLine("Contact deleted:");
                Console.WriteLine("Name: " + contact.FirstName + " " + contact.LastName);

                // Display all contacts in the address book after the delete
                Console.WriteLine("All Contacts:");
                addressBook.PrintContacts();

                Console.ReadLine();
            }
        }


    }

}

