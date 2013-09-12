using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            HousePlant Philodendron = new HousePlant();
            Philodendron.Price = 29.99;
            Philodendron.PlantName = "Philodendron";
            Philodendron.Fed = "true";

            HousePlant Tree = new HousePlant();
            Tree.Price = 54.23;
            Tree.PlantName = "Tree";
            Tree.Fed = "false";

            HousePlant Fern = new HousePlant();
            Fern.Price = 22.69;
            Fern.PlantName = "fern";
            Fern.Fed = "True";
        }
    }
}
