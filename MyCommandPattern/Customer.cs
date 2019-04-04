using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCommandPattern
{
    //Invoker
    class Customer
    {
        private ShoppingCart _shoppingCart;
        private OrderCommand _orderCommand;
        private Item _item;

        public Customer()
        {
            _shoppingCart = new ShoppingCart();
        }
        public void SetCommand(int commandOption)
        {
            _orderCommand = new CommandFactory().GetCommand(commandOption);
        }

        public void SetMenuItem(Item item)
        {
            _item = item;
        }

        public void ExecuteCommand()
        {
            _shoppingCart.ExecuteCommand(_orderCommand, _item);
        }

        public void ShowCurrentOrder()
        {
            _shoppingCart.ShowCurrentItems();
        }
    }

    public class CommandFactory
    {
        //Factory method
        public OrderCommand GetCommand(int commandOption)
        {
            switch (commandOption)
            {
                case 1:
                    return new AddCommand();
                case 2:
                    return new ModifyCommand();
                default:
                    return new AddCommand();
            }
        }
    }

}
