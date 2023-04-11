using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDecorator2023
{
     class Macon :MenuItemDecorator
    {
        public Macon(MenuItem Decorated) : base(Decorated)
        {
            this.Description = "Not Bacon but Bacon Halaal";
            this.Price = 25;
        }        
    }
}
