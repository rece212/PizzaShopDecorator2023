using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDecorator2023
{
    class Ham : MenuItemDecorator
    {
        public Ham(MenuItem Decorated) : base(Decorated)
        {
            this.Description = "Ham";
            this.Price = 30;
        }
    }
}
