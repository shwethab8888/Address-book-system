using System;
using System.Collections.Generic;
using System.Linq;
using static Address_Book.AddressBookMain;

namespace Address_Book
{
        public class EditContact
        {
            public static void Edit_Contact(List<CreateContact> contacts)
            {
                Console.Write("Enter the first name of the contact you want to edit: ");
                var firstName = Console.ReadLine();

                Console.Write("Enter the last name of the contact you want to edit: ");
                var lastName = Console.ReadLine();

                // Find the contact with the given first and last names
                var contactToEdit = contacts.FirstOrDefault(c => c.FirstName == firstName && c.LastName == lastName);

                if (contactToEdit == null)
                {
                    Console.WriteLine($"Contact not found with first name {firstName} and last name {lastName}");
                }
                else
                {
                    Console.WriteLine("Enter the new details for the contact:");

                    Console.Write("First Name: ");
                    var newFirstName = Console.ReadLine();

                    Console.Write("Last Name: ");
                    var newLastName = Console.ReadLine();

                    Console.Write("Address: ");
                    var newAddress = Console.ReadLine();

                    Console.Write("City: ");
                    var newCity = Console.ReadLine();

                    Console.Write("State: ");
                    var newState = Console.ReadLine();

                    Console.Write("Zip: ");
                    var newZip = Console.ReadLine();

                    Console.Write("Phone Number: ");
                    var newPhoneNumber = Console.ReadLine();

                    Console.Write("Email: ");
                    var newEmail = Console.ReadLine();

                    // Update the contact with the new details
                    contactToEdit.FirstName = newFirstName;
                    contactToEdit.LastName = newLastName;
                    contactToEdit.Address = newAddress;
                    contactToEdit.City = newCity;
                    contactToEdit.State = newState;
                    contactToEdit.Zip = newZip;
                    contactToEdit.Phone = newPhoneNumber;
                    contactToEdit.Email = newEmail;

                    Console.WriteLine("Contact details updated successfully.");
                }
            }
        }
    

}
    


