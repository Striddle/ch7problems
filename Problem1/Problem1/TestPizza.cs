using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ch7problems
{
    class Pizza
    {
        // Private DATA variables
        private string topping;
        private int diameter;
        private double price;

        // Public properties that manipulate data variables
        public string Topping
        {
            get
            {
                return topping;
            }

            set
            {
                topping = value;
            }
        }

        public int Diameter
        {
            get
            {
                return diameter;
            }

            set
            {
                diameter = 12;
            }
        }
        public double Price
        {
            get
            {
                return Price;
            }

            set
            {
                Price = 13.99;
            }
        }
    }
}

