using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCommandPattern
{
    public abstract class OrderCommand
    {
        public abstract void Execute(List<Item> shoppingList, Item item);
    }
}
