using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            name = "The best pepperoni pizza";
            dough = "Thick dough";
            sauce = "sweet sauce";
            toppings.Add("Tomato");
        }
    }
}
