using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ch7problems
{
    class TestCircle
    {
        // Private DATA variables
        private string radius;
        private string area;
        private double diameter;

        // Public properties that manipulate data variables
        public string Radius
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
        public string Area
        {
            get
            {
                return area;
            }

            set
            {
                area = value;
            }
        }
    }
}
