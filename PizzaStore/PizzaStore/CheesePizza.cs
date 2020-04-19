using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            name = "The best cheese pizza";
            dough = "very thin dough";
            sauce = "very spicy sauce";
            toppings.Add("Black olives");
            toppings.Add("cheese");
        }
    }
}
