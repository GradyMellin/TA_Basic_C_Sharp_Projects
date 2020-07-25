using System;
using System.Collections.Generic;

namespace ExceptionHandlingAssingment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>() { 5, 23, 8, 6, 10, 7, 42, 87 };
            try
            {
                Console.WriteLine("Please enter a whole number for each integer in the list to be divided by: ");
                int numIn = Convert.ToInt32(Console.ReadLine());
                foreach (int e in numList)
                {
                    int quotient = e / numIn;
                    Console.WriteLine(e + " divided by " + numIn + " is equal to " + quotient);

                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please provide a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can not be divided my zero. ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("its finished.");
            Console.ReadLine();
        }
    }
}
