using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combinedTotal = total + otherTotal;
            //Console.WriteLine(combinedTotal);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine(difference);
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 10 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //bool trueOrFalse = 10 < 3;
            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            Console.WriteLine("Please input a number:");
            string s_inputNum = Console.ReadLine();
            int inputNum = Convert.ToInt32(s_inputNum);
            int multipliedBy50 = inputNum * 50;
            Console.WriteLine(s_inputNum + " * 50 = " + multipliedBy50.ToString());

            Console.WriteLine("Please input another number: ");
            string s_inputNum2 = Console.ReadLine();
            int inputNum2 = Convert.ToInt32(s_inputNum2);
            int add25 = inputNum2 + 25;
            Console.WriteLine(s_inputNum2 + " + 25 = " + add25.ToString());

            Console.WriteLine("Please input another number: ");
            string s_inputNum3 = Console.ReadLine();
            float inputNum3 = Convert.ToSingle(s_inputNum3);
            float divideBy12point5 = inputNum3 / 12.5f;
            Console.WriteLine(s_inputNum3 + " / 12.5 = " + divideBy12point5.ToString());


            Console.WriteLine("Please input another number: ");
            string s_inputNum4 = Console.ReadLine();
            int inputNum4 = Convert.ToInt32(s_inputNum4);
            bool greaterThan50 = inputNum4 > 50;
            Console.WriteLine("The expression: " + s_inputNum4 + " > 50 is " + greaterThan50.ToString());


            Console.WriteLine("Please input another number: ");
            string s_inputNum5 = Console.ReadLine();
            int inputNum5 = Convert.ToInt32(s_inputNum5);
            int remainderOver7 = inputNum5 % 7;
            Console.WriteLine(s_inputNum5 + " % 7 = " + remainderOver7.ToString());
            Console.ReadLine();


        }
    }
}
