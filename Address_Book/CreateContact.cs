using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagement
{
    public class CreateContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public CreateContact(string firstName, string lastName, string address, string city, string state, string zip, string phone, string email)
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
        public static void Create_Contact()
        {
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

            var contact = new CreateContact(firstName, lastName, address, city, state, zip, phoneNumber, email);

            Console.WriteLine(contact.ToString());

        }
    }
}
