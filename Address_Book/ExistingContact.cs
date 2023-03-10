using System;
using System.Collections.Generic;
using System.Linq;
using static Address_Book.AddressBookMain;

namespace Address_Book
{
    public class EditContact
    {

            private List<CreateContact> _contacts;

            public EditContact(List<CreateContact> contacts)
            {
                _contacts = contacts;
            }

            public void EditContactDetails()
            {
                Console.Write("Enter the first name of the contact to edit: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter the last name of the contact to edit: ");
                string lastName = Console.ReadLine();

                // Find the contact to edit by first and last name
                CreateContact contactToEdit = _contacts.Find(c => c.FirstName == firstName && c.LastName == lastName);

                if (contactToEdit != null)
                {
                    Console.WriteLine($"Enter new details for {contactToEdit.FirstName} {contactToEdit.LastName}:");
                    Console.Write("New Address: ");
                    string address = Console.ReadLine();

                    Console.Write("New City: ");
                    string city = Console.ReadLine();

                    Console.Write("New State: ");
                    string state = Console.ReadLine();

                    Console.Write("New Zip: ");
                    string zip = Console.ReadLine();

                    Console.Write("New Phone Number: ");
                    string phone = Console.ReadLine();

                    Console.Write("New Email: ");
                    string email = Console.ReadLine();

                    // Update the contact's details
                    contactToEdit.Address = address;
                    contactToEdit.City = city;
                    contactToEdit.State = state;
                    contactToEdit.Zip = zip;
                    contactToEdit.Phone = phone;
                    contactToEdit.Email = email;

                    Console.WriteLine("Contact details updated successfully!");
                }
                else
                {
                    Console.WriteLine($"Could not find a contact with the name {firstName} {lastName}");
                }
            }
        }
    

}
