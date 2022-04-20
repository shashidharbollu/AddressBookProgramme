using System;
using AddressBookSolution;
public class Program
{
    public static void Main(string[] args)

    {

        Console.WriteLine("welcome to my address book");
        bool end = true;
        Console.WriteLine("select any option\n  1. display\n end of the programme");
        Contact contact = new Contact();
        AddressBookk address = new AddressBookk();

        while (end)
        {
            Console.WriteLine("choose any option to execute the programme : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    address.Display();
                    break;
                case 2:
                    Console.WriteLine("enter the information : ");
                    string name = Console.ReadLine();
                    address.EditContact(name);
                    break;
                case 0:
                    end = false;
                    Console.WriteLine("choose the correct option");
                    break;

            }

        }
    }
}
