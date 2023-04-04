using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class NoDuplicateEntryAdressBook
    {
        class Contact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                Contact other = (Contact)obj;

                return FirstName.Equals(other.FirstName) && LastName.Equals(other.LastName);
            }

            public override int GetHashCode()
            {
                return FirstName.GetHashCode() ^ LastName.GetHashCode();
            }
        }

        class AddressBook
        {
            private List<Contact> contacts = new List<Contact>();

            public void AddContact(Contact contact)
            {
                if (contacts.Contains(contact))
                {
                    Console.WriteLine("Contact already exists.");
                }
                else
                {
                    contacts.Add(contact);
                    Console.WriteLine("Contact added successfully.");
                }
            }

            public void RemoveContact(Contact contact)
            {
                contacts.Remove(contact);
                Console.WriteLine("Contact removed successfully.");
            }

            public List<Contact> GetContacts()
            {
                return contacts;
            }

            public Contact GetContactByName(string firstName, string lastName)
            {
                return contacts.Find(c => c.FirstName.Equals(firstName) && c.LastName.Equals(lastName));
            }
        }

        public static void NoDuplicateEntry_AddressBook()
        {
            AddressBook addressBook = new AddressBook();

            while (true)
            {
                Console.WriteLine("Enter a command (add, remove, list, exit):");
                string command = Console.ReadLine();

                if (command.Equals("add"))
                {
                    Console.WriteLine("Enter first name:");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Enter last name:");
                    string lastName = Console.ReadLine();

                    Console.WriteLine("Enter address:");
                    string address = Console.ReadLine();

                    Console.WriteLine("Enter city:");
                    string city = Console.ReadLine();

                    Console.WriteLine("Enter state:");
                    string state = Console.ReadLine();

                    Console.WriteLine("Enter zip:");
                    string zip = Console.ReadLine();

                    Console.WriteLine("Enter phone number:");
                    string phone = Console.ReadLine();

                    Console.WriteLine("Enter email:");
                    string email = Console.ReadLine();

                    Contact contact = new Contact
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

                    addressBook.AddContact(contact);
                }
                else if (command.Equals("remove"))
                {
                    Console.WriteLine("Enter first name:");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Enter last name:");
                    string lastName = Console.ReadLine();

                    Contact contact = addressBook.GetContactByName(firstName, lastName);

                    if (contact == null)
                    {
                        Console.WriteLine("Contact not found.");
                    }
                    else
                    {
                        addressBook.RemoveContact(contact);
                    }
                }
                else if (command.Equals("list"))
                {
                    List<Contact> contacts = addressBook.GetContacts();

                    if (contacts.Count == 0)
                    {
                        Console.WriteLine("No contacts found.");
                    }
                    else
                    {
                        foreach (Contact contact in contacts)
                        {
                            Console.WriteLine("Name: {0} {1}", contact.FirstName, contact.LastName);
                            Console.WriteLine("Address: {0}", contact.Address);
                            Console.WriteLine("{0}, {1} {2}", contact.City, contact.State, contact.Zip);
                            Console.WriteLine("Phone: {0}", contact.Phone);
                            Console.WriteLine("Email: {0}",contact.Email);
                        }
                    }
                }
                else if (command.Equals("exit"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid command.");
                }

                Console.WriteLine();
            }
        }
    }
    
}
