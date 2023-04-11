using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDecorator2023
{
    abstract class MenuItem
    {
        public abstract string GetDescription();
        public abstract decimal GetPrice();
    }
}
