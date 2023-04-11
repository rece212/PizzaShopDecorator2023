using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDecorator2023
{
    class Cheese : MenuItemDecorator
    {
        public Cheese(MenuItem Decorated) : base(Decorated)
        {
            this.Description = "Cheesy";
            this.Price = 10;
        }
    }
}
