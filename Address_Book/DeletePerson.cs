using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Address_Book.AddressBookMain;

namespace Address_Book
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

    public class DeletePerson
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

            Console.WriteLine("Enter the information for the contact to delete:");

            Console.Write("First name: ");
            string firstNameToDelete = Console.ReadLine();

            Console.Write("Last name: ");
            string lastNameToDelete = Console.ReadLine();

            Console.Write("Address: ");
            string addressToDelete = Console.ReadLine();

            Console.Write("City: ");
            string cityToDelete = Console.ReadLine();

            Console.Write("State: ");
            string stateToDelete = Console.ReadLine();

            Console.Write("Zip: ");
            string zipToDelete = Console.ReadLine();

            Console.Write("Phone: ");
            string phoneToDelete = Console.ReadLine();

            Console.Write("Email: ");
            string emailToDelete = Console.ReadLine();

            ContactPerson personToDelete = new ContactPerson
            {
                FirstName = firstNameToDelete,
                LastName = lastNameToDelete,
                Address = addressToDelete,
                City = cityToDelete,
                State = stateToDelete,
                Zip = zipToDelete,
                Phone = phoneToDelete,
                Email = emailToDelete
            };

            bool removed = addressBook.RemoveContact(personToDelete);

            if (removed)
            {
                Console.WriteLine("Contact removed successfully.");
                addressBook.PrintContacts();
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
    }
}







    



