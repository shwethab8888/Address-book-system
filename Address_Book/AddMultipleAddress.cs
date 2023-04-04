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
                Dictionary<string, AddressBook> addressBooks = new Dictionary<string, AddressBook>();

                while (true)
                {
                    Console.WriteLine("Select an option:");
                    Console.WriteLine("1. Create a new address book");
                    Console.WriteLine("2. Add a contact to an existing address book");
                    Console.WriteLine("3. Remove a contact from an existing address book");
                    Console.WriteLine("4. Print all contacts in an existing address book");
                    Console.WriteLine("5. Quit");

                    Console.Write("Enter your choice (1-5): ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter a name for the new address book: ");
                            string addressBookName = Console.ReadLine();

                            AddressBook newAddressBook = new AddressBook();
                            addressBooks.Add(addressBookName, newAddressBook);

                            Console.WriteLine($"Address book '{addressBookName}' created successfully.");
                            break;

                        case "2":
                            Console.Write("Enter the name of the address book to add the contact to: ");
                            string addBookName = Console.ReadLine();

                            if (!addressBooks.ContainsKey(addBookName))
                            {
                                Console.WriteLine($"Address book '{addBookName}' not found.");
                                break;
                            }

                            AddressBook addBook = addressBooks[addBookName];

                            Console.Write("First name: ");
                            string firstName = Console.ReadLine();

                            Console.Write("Last name: ");
                            string lastName = Console.ReadLine();

                            Console.Write("Address: ");
                            string address = Console.ReadLine();

                            Console.Write("City: ");
                            string city = Console.ReadLine();

                            Console.Write("State: ");
                            string state = Console.ReadLine();

                            Console.Write("Zip: ");
                            string zip = Console.ReadLine();

                            Console.Write("Phone: ");
                            string phone = Console.ReadLine();

                            Console.Write("Email: ");
                            string email = Console.ReadLine();

                            ContactPerson newContact = new ContactPerson
                            {
                                FirstName = firstName,
                                LastName = lastName,
                                Address = address,
                                City = city,
                                State = state,
                                Zip = zip,
                                Phone = phone,
                                Email = email
                            };

                            addBook.AddContact(newContact);

                            Console.WriteLine("Contact added successfully.");
                            break;
                    

                        case "3":
                            Console.Write("Enter the name of the address book to remove the contact from: ");
                            string removeBookName = Console.ReadLine();

                            if (!addressBooks.ContainsKey(removeBookName))
                            {
                                Console.WriteLine($"Address book '{removeBookName}' not found.");
                                break;
                            }

                            AddressBook removeBook = addressBooks[removeBookName];

                            Console.Write("First name: ");
                            string firstNameToRemove = Console.ReadLine();

                            Console.Write("Last name: ");
                            string lastNameToRemove = Console.ReadLine();

                            Console.Write("Address: ");
                            string addressToRemove = Console.ReadLine();

                            Console.Write("City: ");
                            string cityToRemove = Console.ReadLine();

                            Console.Write("State: ");
                            string stateToRemove = Console.ReadLine();

                            Console.Write("Zip: ");
                            string zipToRemove = Console.ReadLine();

                            Console.Write("Phone: ");
                            string phoneToRemove = Console.ReadLine();

                            Console.Write("Email: ");
                            string emailToRemove = Console.ReadLine();

                            ContactPerson contactToRemove = new ContactPerson
                            {
                                FirstName = firstNameToRemove,
                                LastName = lastNameToRemove,
                                Address = addressToRemove,
                                City = cityToRemove,
                                State = stateToRemove,
                                Zip = zipToRemove,
                                Phone = phoneToRemove,
                                Email = emailToRemove
                            };

                            bool contactRemoved = removeBook.RemoveContact(contactToRemove);

                            if (contactRemoved)
                            {
                                
                                Console.WriteLine("Enter the name of the address book to print: ");
                                string printBookName = Console.ReadLine();

                                if (!addressBooks.ContainsKey(printBookName))
                                {
                                    Console.WriteLine($"Address book '{printBookName}' not found.");
                                    break;
                                }

                                AddressBook printBook = addressBooks[printBookName];

                                List<ContactPerson> contacts = printBook.GetContacts();

                                if (contacts.Count == 0)
                                {
                                    Console.WriteLine($"No contacts found in address book '{printBookName}'.");
                                    break;
                                }

                                Console.WriteLine($"Contacts in address book '{printBookName}':");

                                foreach (ContactPerson contact in contacts)
                                {
                                    Console.WriteLine($"  {contact.FirstName} {contact.LastName}");
                                    Console.WriteLine($"    Address: {contact.Address}");
                                    Console.WriteLine($"    City: {contact.City}");
                                    Console.WriteLine($"    State: {contact.State}");
                                    Console.WriteLine($"    Zip: {contact.Zip}");
                                    Console.WriteLine($"    Phone: {contact.Phone}");
                                    Console.WriteLine($"    Email: {contact.Email}");
                                }

                                break;
                            }
                            case "5":
                            Console.WriteLine("Goodbye!");
                            return;

                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }

                    Console.WriteLine();
                }


            }
        }
    }
}
    

