using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCommandPattern
{
    class ModifyCommand : OrderCommand
    {
        public override void Execute(List<Item> shoppingList, Item item)
        {
            var oldItem = shoppingList.Where(x => x.Name == item.Name).First();
            oldItem.Price = item.Price;
            oldItem.Amount = item.Amount;
        }
    }
}
