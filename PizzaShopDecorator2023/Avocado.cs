using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDecorator2023
{
    class Avocado : MenuItemDecorator
    {
        public Avocado(MenuItem Decorated) : base(Decorated)
        {
            this.Description = "Avocado";
            this.Price = 15;
        }
    }
}
