using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class AddMultiplePerson
    {
        public static void AddMultiple_Person()

        {
            static void Main(string[] args)
            {
                List<Contact> contacts = new List<Contact>();

                while (true)
                {
                    Console.WriteLine("Enter a person's details to add to the address book (or type 'exit' to quit):");
                    Console.Write("First name: ");
                    string firstName = Console.ReadLine();

                    if (firstName.ToLower() == "exit")
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
                    Console.Write("Zip code: ");
                    string zip = Console.ReadLine();
                    Console.Write("Phone number: ");
                    string phone = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Contact contact = new Contact(firstName, lastName, address, city, state, zip, phone, email);
                    contacts.Add(contact);

                    Console.WriteLine("Contact added to the address book.");
                }

                Console.WriteLine("\nAll contacts in the address book:");
                foreach (Contact contact in contacts)
                {
                    Console.WriteLine(contact);
                }

                Console.ReadLine();
            }
        }

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
                return FirstName + " " + LastName + "\n" +
                       Address + "\n" +
                       City + ", " + State + " " + Zip + "\n" +
                       "Phone: " + Phone + "\n" +
                       "Email: " + Email + "\n";
            }
        }


    }
}
    
