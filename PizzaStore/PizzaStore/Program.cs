using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaStore = new PizzaStore();
            pizzaStore.OrderPizza("cheese");
            pizzaStore.OrderPizza("greek");
            pizzaStore.OrderPizza("pepperoni");
            pizzaStore.OrderPizza("add");
            Console.ReadKey();
        }
    }
}
