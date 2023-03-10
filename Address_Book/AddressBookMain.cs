using System;
using System.Collections.Generic;

namespace Address_Book
{

            public class Contact
            {
                public string FirstName { get; set; }
                public string LastName { get; set; }
                public string Address { get; set; }
                public string City { get; set; }
                public string State { get; set; }
                public string Zip { get; set; }
                public string Phone { get; set; }
                public string Email { get; set; }

                public Contact(string firstName, string lastName, string address, string city, string state, string zip, string phone, string email)
                {
                    FirstName = firstName;
                    LastName = lastName;
                    Address = address;
                    City = city;
                    State = state;
                    Zip = zip;
                    Phone = phone;
                    Email = email;
                }

                public override string ToString()
                {
                    return $"{FirstName} {LastName}\n{Address}\n{City}, {State} {Zip}\nPhone: {Phone}\nEmail: {Email}\n";
                }
            }

            public class AddressBook
            {
                private List<Contact> contacts = new List<Contact>();

                public void AddContact(Contact contact)
                {
                    contacts.Add(contact);
                }

                public void PrintContacts()
                {
                    foreach (Contact contact in contacts)
                    {
                        Console.WriteLine(contact.ToString());
                    }
                }
            }

            public class AddressBookMain
            {
                static void Main(string[] args)
                {
                    AddressBook addressBook = new AddressBook();

                    Console.WriteLine("Add a new contact:");
                    Console.Write("First Name: ");
                    var firstName = Console.ReadLine();

                    Console.Write("Last Name: ");
                    var lastName = Console.ReadLine();

                    Console.Write("Address: ");
                    var address = Console.ReadLine();

                    Console.Write("City: ");
                    var city = Console.ReadLine();

                    Console.Write("State: ");
                    var state = Console.ReadLine();

                    Console.Write("Zip: ");
                    var zip = Console.ReadLine();

                    Console.Write("Phone Number: ");
                    var phoneNumber = Console.ReadLine();

                    Console.Write("Email: ");
                    var email = Console.ReadLine();

                    Contact newContact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
                    addressBook.AddContact(newContact);

                    Console.WriteLine("\nAddress book:");
                    addressBook.PrintContacts();

                    Console.ReadLine();
                }
            }
}

    



