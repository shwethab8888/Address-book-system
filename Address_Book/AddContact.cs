using System;
using System.Collections.Generic;

namespace Address_Book
{
    public class AddContact
    {
        public class Contact
        {
            private string v1;
            private string v2;
            private string v3;
            private string v4;
            private string v5;
            private string v6;
            private string v7;
            private string v8;

            public Contact(string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8)
            {
                this.v1 = v1;
                this.v2 = v2;
                this.v3 = v3;
                this.v4 = v4;
                this.v5 = v5;
                this.v6 = v6;
                this.v7 = v7;
                this.v8 = v8;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string Phone { get; internal set; }
        }

        public class AddressBook
        {
            private List<Contact> contacts;

            public AddressBook()
            {
                contacts = new List<Contact>();
            }

            public void AddContact(Contact contact)
            {
                contacts.Add(contact);
            }

            public void PrintContacts()
            {
                foreach (Contact contact in contacts)
                {
                    Console.WriteLine("Name: " + contact.FirstName + " " + contact.LastName);
                    Console.WriteLine("Address: " + contact.Address);
                    Console.WriteLine("City: " + contact.City);
                    Console.WriteLine("State: " + contact.State);
                    Console.WriteLine("Zip: " + contact.Zip);
                    Console.WriteLine("Phone Number: " + contact.PhoneNumber);
                    Console.WriteLine("Email: " + contact.Email);
                    Console.WriteLine();
                }
            }

            internal void AddContact(object newContact)
            {
                throw new NotImplementedException();
            }

            internal Contact FindContactByName(string? firstName, string? lastName)
            {
                throw new NotImplementedException();
            }

            internal IEnumerable<Contact> GetContacts()
            {
                throw new NotImplementedException();
            }
        }

        public class AddressBookMain
        {
            public static void AddressBookMainMethod()
            {
                AddressBook addressBook = new AddressBook();

                Console.WriteLine("Add a new contact to the address book:");

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

                Console.Write("Zip: ");
                string zip = Console.ReadLine();

                Console.Write("Phone Number: ");
                string phoneNumber = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Contact contact = new Contact();
                contact.FirstName = firstName;
                contact.LastName = lastName;
                contact.Address = address;
                contact.City = city;
                contact.State = state;
                contact.Zip = zip;
                contact.PhoneNumber = phoneNumber;
                contact.Email = email;

                addressBook.AddContact(contact);

                Console.WriteLine("Address book contents:");
                addressBook.PrintContacts();
            }
        }
    }
}
