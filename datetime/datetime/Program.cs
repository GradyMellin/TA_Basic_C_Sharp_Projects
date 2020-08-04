using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            TimeSpan xHours = now + TimeSpan.FromHours(number);
            Console.WriteLine("In " + number + " hours it will be " + xHours);
            Console.ReadLine();
        }
    }
}
