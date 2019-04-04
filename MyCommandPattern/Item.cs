using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCommandPattern
{
    public class Item
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        public Item(string name, int amount, double price)
        {
            Name = name;
            Amount = amount;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Price: {Price}");
        }
    }
}
