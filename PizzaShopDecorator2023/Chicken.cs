using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDecorator2023
{
    class Chicken : MenuItemDecorator
    {
        public Chicken(MenuItem Decorated) : base(Decorated)
        {
            this.Description = "Real Chicken not beef";
            this.Price = 20;
        }
    }
}
