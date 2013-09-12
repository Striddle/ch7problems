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

            Pizza size = new Pizza();
            size.Diameter = 12;

            Pizza price = new Pizza();
            price.Price = 13.99;
        }
    }
}
