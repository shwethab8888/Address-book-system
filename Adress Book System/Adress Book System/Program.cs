namespace Adress_Book_System
{
    using System;
    using System.Collections.Generic;

    namespace AddressBook
    {
        // Contact Person class
        public class ContactPerson
        {
           public ContactPerson(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
{
    FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
    LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
    Address = address ?? throw new ArgumentNullException(nameof(address));
    City = city ?? throw new ArgumentNullException(nameof(city));
    State = state ?? throw new ArgumentNullException(nameof(state));
    Zip = zip ?? throw new ArgumentNullException(nameof(zip));
    PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
    Email = email ?? throw new ArgumentNullException(nameof(email));
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

        // Address Book class
        public class AddressBook
        {
            private List<ContactPerson> contactList;

            public AddressBook()
            {
                contactList = new List<ContactPerson>();
            }

            public void AddContact(ContactPerson person)
            {
                contactList.Add(person);
            }

            public void EditContact(string firstName, string lastName)
            {
                // find contact to edit based on first and last name
                ContactPerson person = FindContact(firstName, lastName);
                if (person == null)
                {
                    Console.WriteLine("Contact not found.");
                    return;
                }

                // get updated details from user input
                Console.WriteLine("Enter updated details for this contact:");
                Console.Write("Address: ");
                person.Address = Console.ReadLine();
                Console.Write("City: ");
                person.City = Console.ReadLine();
                Console.Write("State: ");
                person.State = Console.ReadLine();
                Console.Write("Zip: ");
                person.Zip = Console.ReadLine();
                Console.Write("Phone number: ");
                person.PhoneNumber = Console.ReadLine();
                Console.Write("Email: ");
                person.Email = Console.ReadLine();

                Console.WriteLine("Contact updated successfully.");
            }

            public void DeleteContact(string firstName, string lastName)
            {
                // find contact to delete based on first and last name
                ContactPerson person = FindContact(firstName, lastName);
                if (person == null)
                {
                    Console.WriteLine("Contact not found.");
                    return;
                }

                contactList.Remove(person);
                Console.WriteLine("Contact deleted successfully.");
            }

            private ContactPerson FindContact(string firstName, string lastName)
            {
                // search for contact based on first and last name
                foreach (ContactPerson person in contactList)
                {
                    if (person.FirstName == firstName && person.LastName == lastName)
                    {
                        return person;
                    }
                }

                return null;
            }
        }

        // Address Book Main class
        public class AddressBookMain
        {
            private static Dictionary<string, AddressBook> addressBooks;

            static void Main(string[] args)
            {
                // initialize dictionary of address books
                addressBooks = new Dictionary<string, AddressBook>();

                Console.WriteLine("Welcome to Address Book Program!");

                // loop for menu options
                while (true)
                {
                    Console.WriteLine("\nMENU:");
                    Console.WriteLine("1. Create a new contact");
                    Console.WriteLine("2. Add a contact to an address book");
                    Console.WriteLine("3. Edit an existing contact");
                    Console.WriteLine("4. Delete a contact");
                    Console.WriteLine("5. Add multiple contacts to an address book");
                    Console.WriteLine("6. Create a new address book");
                    Console.WriteLine("7. Exit");

                    Console.Write("\nEnter your choice (1-7): ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            CreateNewContact();
                            break;
                        case 2:
                            AddContactToAddressBook();
                            break;
                        case 3:
                            EditExistingContact();
                            break;
                        case 4:
                            DeleteContact();
                            break;
                        case 5:
                            AddMultipleContactsToAddressBook();
                            break;
                        case 6:
                            CreateNewAddressBook();
                            break;
                        case 7:
                            Console.WriteLine("Exiting program...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }

            private static void CreateNewContact()
            {
                // get details from user input
                Console.WriteLine("\nEnter contact details:");
                Console.Write("First name: ");
                string firstName = Console.ReadLine();
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
                Console.Write("Phone number: ");
                string phoneNumber = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();

                // create new contact object
                ContactPerson person = new ContactPerson(firstName, lastName, address, city, state, zip, phoneNumber, email);


                Console.WriteLine("New contact created successfully.");
                Console.WriteLine("\nCONTACT DETAILS:");
                DisplayContactDetails(person);
            }

            private static void AddContactToAddressBook()
            {
                // get address book name from user input
                Console.Write("\nEnter address book name: ");
                string addressBookName = Console.ReadLine();

                // check if address book exists in dictionary
                if (!addressBooks.ContainsKey(addressBookName))
                {
                    Console.WriteLine("Address book not found.");
                    return;
                }

                // get details for new contact from user input
                Console.WriteLine("\nEnter contact details:");
                Console.Write("First name: ");
                string firstName = Console.ReadLine();
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
                Console.Write("Phone number: ");
                string phoneNumber = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();

                ContactPerson person = new ContactPerson(firstName, lastName, address, city, state, zip, phoneNumber, email);


                // add contact to address book
                AddressBook addressBook = addressBooks[addressBookName];
                addressBook.AddContact(person);

                Console.WriteLine("Contact added successfully to address book '{0}'.", addressBookName);
                Console.WriteLine("\nCONTACT DETAILS:");
                DisplayContactDetails(person);
            }

            private static void EditExistingContact()
            {
                // get address book name from user input
                Console.Write("\nEnter address book name: ");
                string addressBookName = Console.ReadLine();

                // check if address book exists in dictionary
                if (!addressBooks.ContainsKey(addressBookName))
                {
                    Console.WriteLine("Address book not found.");
                    return;
                }

                // get contact details from user input
                Console.Write("Enter first name of contact to edit: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter last name of contact to edit: ");
                string lastName = Console.ReadLine();

                // edit contact in address book
                AddressBook addressBook = addressBooks[addressBookName];
                ContactPerson person = addressBook.FindContact(firstName, lastName);


                if (person == null)
                {
                    Console.WriteLine("Contact not found.");
                    return;
                }

                Console.WriteLine("\nEnter new contact details:");
                Console.Write("First name (press Enter to keep current value '{0}'): ", person.FirstName);
                string newFirstName = Console.ReadLine();
                if (!string.IsNullOrEmpty(newFirstName))
                {
                    person.FirstName = newFirstName;
                }

                Console.Write("Last name (press Enter to keep current value '{0}'): ", person.LastName);
                string newLastName = Console.ReadLine();
                if (!string.IsNullOrEmpty(newLastName))
                {
                    person.LastName = newLastName;
                }

                Console.Write("Address (press Enter to keep current value '{0}'): ", person.Address);
                string newAddress = Console.ReadLine();
                if (!string.IsNullOrEmpty(newAddress))
                {
                    person.Address = newAddress;
                }

                Console.Write("City (press Enter to keep current value '{0}'): ", person.City);
                string newCity = Console.ReadLine();
                if (!string.IsNullOrEmpty(newCity))
                {
                    person.City = newCity;
                }

                Console.Write("State (press Enter to keep current value '{0}'): ", person.State);
                string newState = Console.ReadLine();
                if (!string.IsNullOrEmpty(newState))
                {
                    person.State = newState;
                }

                Console.Write("Zip (press Enter to keep current value '{0}'): ", person.Zip);
                string newZip = Console.ReadLine();
                if (!string.IsNullOrEmpty(newZip))
                {
                    person.Zip = newZip;
                }

                Console.Write("Phone number (press Enter to keep current value '{0}'): ", person.PhoneNumber);
                string newPhoneNumber = Console.ReadLine();
                if (!string.IsNullOrEmpty(newPhoneNumber))
                {
                    person.PhoneNumber = newPhoneNumber;
                }

                Console.Write("Email (press Enter to keep current value '{0}'): ", person.Email);
                string newEmail = Console.ReadLine();
                if (!string.IsNullOrEmpty(newEmail))
                {
                    person.Email = newEmail;
                }

                Console.WriteLine("Contact edited successfully.");
                Console.WriteLine("\nCONTACT DETAILS:");
                DisplayContactDetails(person);
            }

            //private static void DeleteExistingContact()
            //{
            //    // get address book name from user input
            //    Console.Write("\nEnter address book name: ");
            //    string addressBookName = Console.ReadLine();

            //    // check if address book exists in dictionary
            //    if (!addressBooks.ContainsKey(addressBookName))
            //    {
            //        Console.WriteLine("Address book not found.");
            //        return;
            //    }

            //    // get contact details from user input
            //    Console.Write("Enter first name of contact to delete: ");
            //    string firstName = Console.ReadLine();
            //    Console.Write("Enter last name of contact to delete: ");
            //    string lastName = Console.ReadLine();

            //    // delete contact from address book
            //    AddressBook addressBook = addressBooks[addressBookName];
            //    bool result = addressBook.DeleteContact(firstName, lastName);

            //    if (result)
            //    {
            //        Console.WriteLine("Contact deleted successfully.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Contact not found.");
            //    }
            //}
            private static void DeleteExistingContact()
            {
                // get address book name from user input
                Console.Write("\nEnter address book name: ");
                string addressBookName = Console.ReadLine();

                // check if address book exists in dictionary
                if (!addressBooks.ContainsKey(addressBookName))
                {
                    Console.WriteLine("Address book not found.");
                    return;
                }

                // get contact details from user input
                Console.Write("Enter first name of contact to delete: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter last name of contact to delete: ");
                string lastName = Console.ReadLine();

                // delete contact from address book
                AddressBook addressBook = addressBooks[addressBookName];
                addressBook.DeleteContact(firstName, lastName);

                Console.WriteLine("Contact deleted successfully.");
            }




            private static void AddMultipleContactsToAddressBook()
            {
                // get address book name from user input
                Console.Write("\nEnter address book name: ");
                string addressBookName = Console.ReadLine();

                // check if address book exists in dictionary
                if (!addressBooks.ContainsKey(addressBookName))
                {
                    Console.WriteLine("Address book not found.");
                    return;
                }

                // get number of contacts to add from user input
                Console.Write("Enter number of contacts to add: ");
                int numContacts;
                if (!int.TryParse(Console.ReadLine(), out numContacts))
                {
                    Console.WriteLine("Invalid number.");
                    return;
                }
                AddressBook addressBook = addressBooks[addressBookName];

                // add each contact to the address book
                for (int i = 0; i < numContacts; i++)
                {
                    Console.WriteLine("\nEnter details for contact {0}:", i + 1);

                    Console.Write("First name: ");
                    string firstName = Console.ReadLine();

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

                    Console.Write("Phone number: ");
                    string phoneNumber = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    ContactPerson newContact = new ContactPerson(firstName, lastName, address, city, state, zip, phoneNumber, email);
                    addressBook.AddContact(newContact);
                    Console.WriteLine("Contact added successfully.");
                }
            }

            private static void AddNewAddressBook()
            {
                // get name for new address book from user input
                Console.Write("\nEnter name for new address book: ");
                string newAddressBookName = Console.ReadLine();

                // check if address book name is already used
                if (addressBooks.ContainsKey(newAddressBookName))
                {
                    Console.WriteLine("Address book with the same name already exists.");
                    return;
                }

                // create new address book and add it to the dictionary
                AddressBook newAddressBook = new AddressBook();
                addressBooks.Add(newAddressBookName, newAddressBook);
                Console.WriteLine("New address book '{0}' added successfully.", newAddressBookName);
            }

            private static void DisplayContactDetails(ContactPerson person)
            {
                Console.WriteLine("First Name: {0}", person.FirstName);
                Console.WriteLine("Last Name: {0}", person.LastName);
                Console.WriteLine("Address: {0}", person.Address);
                Console.WriteLine("City: {0}", person.City);
                Console.WriteLine("State: {0}", person.State);
                Console.WriteLine("Zip: {0}", person.Zip);
                Console.WriteLine("Phone Number: {0}", person.PhoneNumber);
                Console.WriteLine("Email: {0}", person.Email);
            }
        }
        
    }

    // AddressBook class to manage multiple contacts
    class MyAddressBook
    {
        private List<ContactPerson> contacts = new List<ContactPerson>();
        public void AddContact(ContactPerson contact)
        {
            contacts.Add(contact);
        }

        public ContactPerson FindContact(string firstName, string lastName)
        {
            return contacts.Find(c => c.FirstName == firstName && c.LastName == lastName);
        }

        public bool DeleteContact(string firstName, string lastName)
        {
            ContactPerson contactToDelete = FindContact(firstName, lastName);

            if (contactToDelete != null)
            {
                contacts.Remove(contactToDelete);
                return true;
            }

            return false;
        }

        public List<ContactPerson> GetAllContacts()
        {
            return contacts;
        }
    }

    // ContactPerson class to represent a contact person
    class ContactPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public ContactPerson(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }






}