using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ch7problems
{
    class Circle
    {
        // Private DATA variables
        private double radius;

        // Public properties that manipulate data variables
        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

        public double Diameter
        {
            get
            {
                return radius * 2;
            }

        }
        public double Area
        {
            get
            {
                return Math.PI * radius * radius;
            }
        }
    }
}
