using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDecorator2023
{
    abstract class MenuItemDecorator : MenuItem
    {
        MenuItem Decorated = null;
        protected string Description = "";
        protected decimal Price = 0;

        public MenuItemDecorator(MenuItem Decorated)
        {
            this.Decorated = Decorated;
        }
        public override string GetDescription()
        {
            return Description +" "+ Decorated.GetDescription();
        }

        public override decimal GetPrice()
        {
            return Decorated.GetPrice() + Price;
        }

    }
}
