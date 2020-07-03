using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Guess a number?");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool isGuessed = number == 5;

            //do
            //{
            //    switch (number)
            //    {
            //        case 62:
            //            Console.WriteLine("You guessed 62. Guess again.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 29:
            //            Console.WriteLine("You guessed 29. Guess again.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 55:
            //            Console.WriteLine("You guessed 55. Guess again.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 5:
            //            Console.WriteLine("You are correct, the number was 5!");
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("You are wrong! Guess again");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            //while (!isGuessed);

            int x = 10;
            while (x>0)
            {
                Console.WriteLine(x);
                x = x - 1;
            }

            Console.WriteLine("Pick a number between 1 and 100000:");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = num == 4;

            do
            {
                if (num == 4)
                {
                    Console.WriteLine("You Guessed the right number!");
                    isGuessed = true;
                }
                else
                {
                    Console.WriteLine("Oof soo close! guess again!");
                    num = Convert.ToInt32(Console.ReadLine());
                }

            }
                while (!isGuessed);




            Console.ReadLine();
        }
    }
}
