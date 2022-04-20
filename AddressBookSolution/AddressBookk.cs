using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSolution
{
    public class AddressBookk
    {
        List<Contact> addressbook = new List<Contact>();
        public AddressBookk()
        {
            Contact address1 = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Email = Console.ReadLine(),
                Zip = Convert.ToInt32(Console.ReadLine()),
                Phone = Convert.ToInt64(Console.ReadLine()),
            };
            Contact address2 = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Email = Console.ReadLine(),
                Zip = Convert.ToInt32(Console.ReadLine()),
                Phone = Convert.ToInt64(Console.ReadLine()),
            };
            addressbook.Add(address1);
            addressbook.Add(address2);
        }
        public void AddContactToAddressBook(Contact contact)
        {
            addressbook.Add(contact);

        }
        public void Display()
        {
            foreach (var contact in addressbook)
            {
                Console.WriteLine("first name: " + contact.FirstName + "\nlastname: " + contact.LastName + "\naddress: " + contact.Address + "\nstate" + contact.State + "\nemail:" + contact.Email + "\nzip" + contact.Zip + "\nmobile:" + contact.Phone);
            }
        }
        public void EditContact(string name)
        {
            foreach (var contact in addressbook)
            {
                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("Enter the required option : ");
                    int optionn = Convert.ToInt32(Console.ReadLine());
                    switch (optionn)
                    {
                        case 1:
                            Console.WriteLine("enter the first name you want to edit");
                            contact.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("enter the last name you want to edit : ");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("enter the address you want to edit :");
                            contact.Address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("enter the city: ");
                            contact.City = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("enter the state you want to edit :");
                            contact.State = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("enter the email you want to edit :");
                            contact.Email = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("enter the zip you want to edit :");
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("enter the phone you want to edit :");
                            contact.Phone = Convert.ToInt64(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Choose the right option : ");
                            break;


                    }

                }
                Display();
            }
        }
        public void DeletingContactInAddressBookk(string name)
        { 
        Contact d = new Contact();
            foreach (var contact in addressbook)
            {
                if (contact.FirstName.Equals(name))
                { 
                d = contact;
                }
            }
            addressbook.Remove(d);
            Display();
            
        }
    }
        
    
}

        

    
    

