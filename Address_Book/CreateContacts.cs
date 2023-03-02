using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class CreateContacts
    {
        public class Contact
        {

            public Contact()
            {
                FirstName = "";
                LastName = "";
                Address = "";
                City = "";
                State = "";
                Zip = "";
                PhoneNumber = "";
                Email = "";
            }


            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
        }

        public class AddressBook
        {
            private List<Contact> contacts = new List<Contact>();

            public void AddContact(Contact contact)
            {
                contacts.Add(contact);
            }

            public void DeleteContact(Contact contact)
            {
                contacts.Remove(contact);
            }

            public List<Contact> SearchContacts(string search)
            {
                return contacts.FindAll(c =>
                    c.FirstName.Contains(search) ||
                    c.LastName.Contains(search) ||
                    c.Address.Contains(search) ||
                    c.City.Contains(search) ||
                    c.State.Contains(search) ||
                    c.Zip.Contains(search) ||
                    c.PhoneNumber.Contains(search) ||
                    c.Email.Contains(search)
                );
            }
        }

    }
}

