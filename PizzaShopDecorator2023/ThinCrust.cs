using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDecorator2023
{
    class ThinCrust : MenuItem
    {
        public override string GetDescription()
        {
            return "Thin Crust Pizza";
        }

        public override decimal GetPrice()
        {
            return 30;
        }
    }
}
