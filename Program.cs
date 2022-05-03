// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
class AddressPrompt
{
    AddressBook book;

    public AddressPrompt()
    {
        book = new AddressBook();
    }

    static void Main(string[] args)
    {
        string selection = "";
        AddressPrompt prompt = new AddressPrompt();

        prompt.displayMenu();
        while (!selection.ToUpper().Equals("Q"))
        {
            Console.WriteLine("Selection: ");
            selection = Console.ReadLine();
            prompt.performAction(selection);
        }
    }
    void displayMenu()
    {
        Console.WriteLine("Main Menu");
        Console.WriteLine("=========");
        Console.WriteLine("E - Edit an Address");
    }

    void performAction(string selection)
    {
        string name = "";
        string address = "";
        switch (selection.ToUpper())
        {

      Console.WriteLine("Enter Name to Edit: ");
        name = Console.ReadLine();
        Address addr = book.find(name)C

        if (addr == null)
        {
            Console.WriteLine("Address for {0} count not be found.", name);
        }
        else
        {
            Console.WriteLine("Enter new Address: ");
            addr.address = Console.ReadLine();
            Console.WriteLine("Address updated for {0}", name);
        }
        break;
    }
}