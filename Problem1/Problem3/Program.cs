using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ch7problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza();
            pizza.Topping = "pepperoni";
            pizza.Diameter = 12;
            pizza.Price = 13.99;
        }
    }
}