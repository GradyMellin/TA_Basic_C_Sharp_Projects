using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you qualify for car incurance?\nWhat is your age?");
            short age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI(if yes say 'true' or if no say 'false')?");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            short tickets = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Qualification status:");
            bool qualify = age > 15 && dui == false && tickets <= 3;
            Console.WriteLine(qualify);
            Console.ReadLine();
        }
    }
}
