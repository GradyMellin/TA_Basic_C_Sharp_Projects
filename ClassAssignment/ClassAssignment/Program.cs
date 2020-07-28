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
            //InputNumber number = new InputNumber();
            //Console.WriteLine("Please enter a number: ");
            //number.NumIn = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You have entered " + number.NumIn);
            //Console.WriteLine(number.NumIn + " * 10 = " + number.TimesTen());
            //Console.WriteLine(number.NumIn + " + 5 = " + number.PlusFive());
            //Console.WriteLine(number.NumIn + " / 2 has a remainder of " + number.ModulesTwo());

            InputNumber2 number = new InputNumber2();
            Console.WriteLine("Please enter an integer number: ");
            int intIn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intIn + " * 10 = " + number.TimesFive(intIn));
            Console.WriteLine("Please enter a decimal number: ");
            decimal decIn = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(decIn + " * 10 = " + number.TimesFive(decIn));
            Console.WriteLine("Please enter a number as a string: ");
            string strIn = Console.ReadLine();
            Console.WriteLine(strIn + " * 10 = " + number.TimesFive(strIn));

            Console.ReadLine();
        }
    }
}
