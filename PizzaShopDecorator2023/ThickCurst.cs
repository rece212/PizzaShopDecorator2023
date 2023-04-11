using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDecorator2023
{
    class ThickCurst : MenuItem
    {
        public override string GetDescription()
        {
            return "Thick Crust Pizza";
        }

        public override decimal GetPrice()
        {
            return 30;
        }
    }
}
