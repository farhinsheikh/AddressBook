using System;
using System.Collections;
using System.Collections.Generic;


namespace AddressBookApp
{
    class Program
    {
        private ArrayList personsList = new ArrayList();

        public void addPerson()
        {
            Console.WriteLine("enter first name");
            String firstName = Console.ReadLine();
            Console.WriteLine("enter last name");
            String lastName = Console.ReadLine();
            Console.WriteLine("enter address");
            String address = Console.ReadLine();
            Console.WriteLine("enter city");
            String city = Console.ReadLine();
            Console.WriteLine("enter state");
            String state = Console.ReadLine();
            Console.WriteLine("enter zip");
            String zip = Console.ReadLine();
            Console.WriteLine("enter phone number");
            String phoneNumber = Console.ReadLine();
            Person person1 = new Person(firstName, lastName, address, city, state, zip, phoneNumber);
            personsList.Add(person1);
            Console.WriteLine("Added Successfully");
        }
        public Person getObjectWithName()
        {
            Console.WriteLine("enter first name of person ");
            String firstName = Console.ReadLine();
            foreach (Person person in personsList)
            {
                if (person.getFirstName().Equals(firstName))
                {
                    return person;
                }
            }
            return null;
        }

        public void editperson()
        {
            Person personToEdit = new Person("", "", "", "", "", "", "");
            Console.WriteLine("enter first name of person to edit");
            String firstName = Console.ReadLine();
            foreach (Person person in personsList)
            {
                if (person.getFirstName().Equals(firstName))
                {
                    personToEdit = person;
                }
            }
            int quit = 0;
            do
            {
                Console.WriteLine("enter 1 for editing address");
                Console.WriteLine("enter 2 for editing city");
                Console.WriteLine("enter 3 for editing state");
                Console.WriteLine("enter 4 for editing zip");
                Console.WriteLine("enter 5 for editing phone number");
                Console.WriteLine("enter 6 to quit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("enter new address");
                        String address = Console.ReadLine();
                        personToEdit.SetAddress(address);
                        break;
                    case 2:
                        Console.WriteLine("enter new city");
                        String city = Console.ReadLine();
                        personToEdit.setCity(city);
                        break;
                    case 3:
                        Console.WriteLine("enter new state");
                        String state = Console.ReadLine();
                        personToEdit.setState(state);
                        break;
                    case 4:
                        Console.WriteLine("enter new zip");
                        String zip = Console.ReadLine();
                        personToEdit.setZip(zip);
                        break;
                    case 5:
                        Console.WriteLine("enter new phone number");
                        String phoneNo = Console.ReadLine();
                        personToEdit.setPhoneNo(phoneNo);
                        break;
                    case 6:
                        quit = 1;
                        break;
                }

            } while (quit == 0);

        }
        public void displayAddressBook()
        {
            foreach (Person person in personsList)
            {
                Console.WriteLine(person);
            }
        }
        public void deletePerson()
        {
            Person personToDelete = getObjectWithName();
            personsList.Remove(personToDelete);
        }
          
            static void Main(string[] args)
            {
                int quit = 0;
                Program addressBook = new Program();
                do
                {
                    Console.WriteLine("enter 1 for adding person to address book");
                    Console.WriteLine("enter 2 for editing person");
                    Console.WriteLine("enter 3 for deleting person");
                    Console.WriteLine("enter 4 to quit");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            addressBook.addPerson();
                            break;
                        case 2:
                            addressBook.displayAddressBook();
                            addressBook.editperson();
                            break;
                        case 3:
                           addressBook.displayAddressBook();
                            addressBook.deletePerson();
                            break;
                        case 4:
                            quit = 1;
                            break;
                    }
                } while (quit == 0);
               // addressBook.displayAddressBook();


            }
        
    }
}

