using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDecorator2023
{
    class Bacon : MenuItemDecorator
    {
        public Bacon(MenuItem Decorated) : base(Decorated)
        {
            this.Description = "Bacon";
            this.Price = 20;
        }
    }
}
