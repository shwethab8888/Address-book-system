using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class AddMultiplePerson
    {
        public class ContactPerson
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
        }

        public class AddressBook
        {
            private List<ContactPerson> contacts;

            public AddressBook()
            {
                contacts = new List<ContactPerson>();
            }

            public void AddContact(ContactPerson person)
            {
                contacts.Add(person);
            }

            public bool RemoveContact(ContactPerson person)
            {
                return contacts.Remove(person);
            }

            public void PrintContacts()
            {
                Console.WriteLine("Address Book Contacts:");
                foreach (var person in contacts)
                {
                    Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Address: {person.Address}, City: {person.City}, State: {person.State}, Zip: {person.Zip}, Phone: {person.Phone}, Email: {person.Email}");
                }
            }
        }

        public class AddMultiple_Person
        {
            static void Main(string[] args)
            {
                AddressBook addressBook = new AddressBook();

                Console.WriteLine("Add contacts to address book:");
                while (true)
                {
                    Console.Write("First name (or 'quit' to finish adding): ");
                    string firstName = Console.ReadLine();
                    if (firstName == "quit")
                    {
                        break;
                    }

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

                    ContactPerson person = new ContactPerson
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

                    addressBook.AddContact(person);
                }

                addressBook.PrintContacts();
            }
        }
    }

}

    

    
