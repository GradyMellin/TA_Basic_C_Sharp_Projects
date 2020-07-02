using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //int currentTemperature = 70;
            int roomTemperature = 70;

            Console.WriteLine("Hi Whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + ", what is the temperature where you are? ");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());

            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else if (currentTemperature < roomTemperature)
            {
                Console.WriteLine("It is cooler than room temperature.");
            }
            else
            {
                Console.WriteLine("Something went wrong here....");
            }
            Console.WriteLine("What temperature do you like your thermostat?");
            int favTemperature = Convert.ToInt32(Console.ReadLine());
            string favResult = favTemperature == 69 ? "Yes, that is the perfect temperature!" : "Oof, you are absolutely wrong!";
            Console.WriteLine(favResult);
            Console.ReadLine();

        }
    }
}
