using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            InputNumber number = new InputNumber();
            Console.WriteLine("Please enter a number: ");
            number.NumIn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have entered " + number.NumIn);
            Console.WriteLine(number.NumIn + " * 10 = " + number.TimesTen());
            Console.WriteLine(number.NumIn + " + 5 = " + number.PlusFive());
            Console.WriteLine(number.NumIn + " / 2 has a remainder of " + number.ModulesTwo());

            Console.ReadLine();
        }
    }
}
