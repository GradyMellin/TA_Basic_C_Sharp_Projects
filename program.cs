using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>() { "5", "23", "8", "6", "10", "7", "42", "87" };
            Console.WriteLine("Please enter a whole number for each integer in the list to be divided by: ");
            int numIn = Convert.ToInt32(Console.ReadLine());
            try
            {
                foreach (int e in numList)
                {
                    int quotient = e / numIn;
                    Console.WriteLine(e + " divided by " + numIn + " is equal to " + quotient);

                }
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
