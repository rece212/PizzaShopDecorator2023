using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDecorator2023
{
    class Sub : MenuItem
    {
        public override string GetDescription()
        {
            return "Sub";
        }

        public override decimal GetPrice()
        {
            return 20;
        }
    }
}
