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
                Console.WriteLine("first name: " + contact.FirstName+ "\nlastname: "+ contact.LastName + "\naddress: "+ contact.Address +"\nstate"+contact.State+"\nemail:"+contact.Email+"\nzip"+contact.Zip+"\nmobile:"+contact.Phone);
            }
        }

    }
}
        

    
    

