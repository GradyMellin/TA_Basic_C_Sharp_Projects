﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxWeight = 50;

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nPlease enter the package weight: ");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            if (packWeight <= maxWeight)
            {
                Console.WriteLine("Please enter the package width: ");
                int packWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height: ");
                int packHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length: ");
                int packLength = Convert.ToInt32(Console.ReadLine());
                double packageCost = (packWeight * packHeight * packLength * packWidth) / 100.0;
                Console.WriteLine("The estimated cost of your package is: $"+ packageCost.ToString());
                Console.WriteLine("Thank you.");
                
            }
            else
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            Console.ReadLine();

        }
    }
}
