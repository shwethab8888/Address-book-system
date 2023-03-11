using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Address_Book.AddressBookMain;

namespace Address_Book
{
    public class AddMultipleAddress
    {
        public static void AddMultiple_Address()
        {
  
            static void Main(string[] args)
            {
                Dictionary<string, AddressBookMain> addressBooks = new Dictionary<string, AddressBookMain>();

                while (true)
                {
                    Console.WriteLine("Enter a name for the new Address Book (or enter 'q' to quit):");
                    string addressBookName = Console.ReadLine();

                    if (addressBookName == "q")
                    {
                        break;
                    }

                    // Check if the Address Book name already exists
                    if (addressBooks.ContainsKey(addressBookName))
                    {
                        Console.WriteLine($"An Address Book with name '{addressBookName}' already exists. Please enter a different name.");
                        continue;
                    }

                    // Create a new Address Book and add it to the dictionary
                    AddressBookMain addressBook = new AddressBookMain();
                    addressBooks[addressBookName] = addressBook;

                    Console.WriteLine($"Address Book '{addressBookName}' has been created.");
                }

                // Loop to add contacts to an Address Book
                while (true)
                {
                    Console.WriteLine("Enter the name of the Address Book to add a contact (or enter 'q' to quit):");
                    string addressBookName = Console.ReadLine();

                    // Exit the loop if the user enters 'q'
                    if (addressBookName == "q")
                    {
                        break;
                    }

                    // Check if the Address Book exists
                    if (!addressBooks.ContainsKey(addressBookName))
                    {
                        Console.WriteLine($"An Address Book with name '{addressBookName}' does not exist. Please enter a valid name.");
                        continue;
                    }

                    // Prompt the user to enter the contact details
                    Console.WriteLine("Enter the details of the contact:");
                    Console.Write("First Name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Last Name: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Address: ");
                    string address = Console.ReadLine();
                    Console.Write("City: ");
                    string city = Console.ReadLine();
                    Console.Write("State: ");
                    string state = Console.ReadLine();
                    Console.Write("Zip Code: ");
                    string zip = Console.ReadLine();
                    Console.Write("Phone Number: ");
                    string phoneNumber = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    // Create a new Contact object
                    CreateContact contact = new CreateContact(firstName, lastName, address, city, state, zip, phoneNumber, email);

                    // Add the contact to the Address Book
                    addressBooks[addressBookName].AddContact(contact);

                    Console.WriteLine($"Contact '{firstName} {lastName}' has been added to the Address Book '{addressBookName}'.");
                }

                // Loop to print all the Address Books and their contacts
                foreach (var addressBookEntry in addressBooks)
                {
                    Console.WriteLine($"Address Book '{addressBookEntry.Key}':");
                    addressBookEntry.Value.PrintContacts();
                    Console.WriteLine();
                }

                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }

}
    

