using System;
using AddressBookSolution;
class Program
{
    public static void Main(string[] args)

    {
        Contact contact = new Contact();
        contact.LastName = Console.ReadLine();
        contact.Address = Console.ReadLine();
        contact.City = Console.ReadLine();
        contact.State = Console.ReadLine();
        contact.Email = Console.ReadLine();
        contact.Zip = Convert.ToInt32(Console.ReadLine());
        contact.Phone = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine(contact.FirstName + " "+contact.LastName+ " "+ contact.Address+ " "+ contact.City + " "+ contact.State + " "+ contact.Email+" "+ contact.Zip + " "+contact.Phone);

    }
}
