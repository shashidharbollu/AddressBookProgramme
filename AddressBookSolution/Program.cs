﻿using System;
using AddressBookSolution;
public class Program
{
    public static void Main(string[] args)

    {

        Console.WriteLine("welcome to my address book");
        bool end = true;
        Console.WriteLine("select any option\n  1. display\n 2.editContact\n 3.deletecontact\n 4.addmultiplecontacts end of the programme");
       
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
                case 3:
                    Console.WriteLine("ENTER THE INF TO BE DELETED");
                    string d1 = Console.ReadLine();
                    address.DeletingContactInAddressBookk(d1);
                    break;
                case 4:
                    address.addAddressBookk();
                    break;
               
                    


                case 0:
                    end = false;
                    Console.WriteLine("choose the correct option");
                    break;

            }

        }
    }
}
