﻿using System;
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
            pizzaStore.OrderPizza();
            Console.ReadKey();
        }
    }
}