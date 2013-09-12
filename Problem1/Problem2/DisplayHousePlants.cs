using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2
{
    class DisplayHousePlants
    {
    }
    class HousePlant
    {
        private double price;
        private string plantname;
        private string fed;

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = 29.99;
            }
        }
        public string PlantName
        {
            get
            {
                return plantname;
            }
            set
            {
                plantname = value;
            }
        }
        public string Fed
        {
            get
            {
                return fed;
            }
            set
            {
                value = "true";
            }
        }
    }
}
