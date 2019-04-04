using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCommandPattern
{
    //concrete command
    class AddCommand : OrderCommand
    {
        public override void Execute(List<Item> shoppingList, Item item)
        {
            shoppingList.Add(item);
        }
    }
}
