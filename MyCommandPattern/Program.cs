using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.SetCommand(1);
            customer.SetMenuItem(new Item("Verdus boots",1,110.00d));
            customer.ExecuteCommand();

            customer.SetCommand(1);
            customer.SetMenuItem(new Item("Numnah", 16, 8.00));
            customer.ExecuteCommand();

            customer.SetCommand(1);
            customer.SetMenuItem(new Item("Horse", 1, 10000.00));
            customer.ExecuteCommand();


            customer.SetCommand(2);
            customer.SetMenuItem(new Item("Horse",1,7000.00));
            customer.ExecuteCommand();

            customer.ShowCurrentOrder();

            Console.ReadKey();
        }
    }
}
