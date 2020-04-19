using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class PizzaStore
    {
        public void OrderPizza(String type)
        {
            Pizza pizza;
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "greek":
                    pizza = new GreekPizza();
                    break;
                case "pepperoni":
                pizza = new PepperoniPizza();
                    break;
                default:
                    Console.WriteLine("We donot have this type of pizza.");
                    return;
            }
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}
