using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCommandPattern
{
    //receiver
    public class ShoppingCart
    {
        public List<Item> shoppingList { get; set; }

        public ShoppingCart()
        {
            shoppingList = new List<Item>();
        }

        public void ExecuteCommand(OrderCommand orderCommand, Item item)
        {
            orderCommand.Execute(this.shoppingList, item);
        }

        public void ShowCurrentItems()
        {
            foreach (var item in shoppingList)
            {
                item.Display();
            }
            Console.WriteLine("-----------------------");
        }
    }
}
