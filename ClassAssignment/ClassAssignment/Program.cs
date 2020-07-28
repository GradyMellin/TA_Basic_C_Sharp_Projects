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

            //InputNumber2 number = new InputNumber2();
            //Console.WriteLine("Please enter an integer number: ");
            //int intIn = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(intIn + " * 10 = " + number.TimesFive(intIn));
            //Console.WriteLine("Please enter a decimal number: ");
            //decimal decIn = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine(decIn + " * 10 = " + number.TimesFive(decIn));
            //Console.WriteLine("Please enter a number as a string: ");
            //string strIn = Console.ReadLine();
            //Console.WriteLine(strIn + " * 10 = " + number.TimesFive(strIn));

            //InputNumbers numbers = new InputNumbers();
            //Console.WriteLine("Enter a number for the base of an exponential expression: ");
            //int baseNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a number for the power of an exponential expression(if left blank your base will be squared): ");
            //string powerStr = Console.ReadLine();
            //if (!string.IsNullOrEmpty(powerStr))
            //{
            //    int powerNum = Convert.ToInt32(powerStr);
            //    Console.WriteLine(baseNum + " to the power of " + powerNum + " is " + numbers.Exponentals(baseNum, powerNum));
            //}
            //else
            //{
            //    Console.WriteLine(baseNum + " to the power of 2 is " + numbers.Exponentals(baseNum));
            //}

            //InputNumber4 numbers = new InputNumber4();
            //Console.WriteLine("Please enter two numbers one after another to see what happens: ");
            //int Num1 = Convert.ToInt32(Console.ReadLine());
            //int Num2 = Convert.ToInt32(Console.ReadLine());
            //numbers.SquareRoot(Num1, Num2);

            InputNumber5 number = new InputNumber5();
            Console.WriteLine("Please enter a number: ");
            int intIn = Convert.ToInt32(Console.ReadLine());
            number.DivideByTwo(intIn, out int quotient);
            Console.WriteLine(quotient);
            Console.WriteLine("Please enter a number: ");
            double intIn2 = Convert.ToDouble(Console.ReadLine());
            number.DivideByTwo(intIn2, out double quotient2);
            Console.WriteLine(quotient2);
            Program.Hi();
            Console.ReadLine();
        }
        public static void Hi()
        {
            Console.WriteLine("Hi this is my static method.");
        }
    }
}
