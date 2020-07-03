using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
    {
        static void Main()
        {
            string[] stringArray = { "this", "is", "a", "string", "array", "with", "8", "elements"};
            Console.WriteLine("Select the index of the string array between 0 and 7: ");
            int stringIndex = Convert.ToInt32(Console.ReadLine());
            if (stringIndex < 8 && stringIndex >= 0)
            {
                Console.WriteLine(stringArray[stringIndex]);
            }
            else
            {
                Console.WriteLine("Sorry there is no element at the index you have selected.");
            }

            int[] intArray = { 1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine("Select the index of the int array: ");
            int intIndex = Convert.ToInt32(Console.ReadLine());
            if (intIndex < 10 && intIndex >= 0)
            {
                Console.WriteLine(intArray[intIndex]);
            }
            else
            {
                Console.WriteLine("Sorry there is no element at the index you have selected.");
            }
        
        

            List<string> stringList = new List<string>() { "this", "is", "a", "string", "list", "with", "8", "elements" };
            Console.WriteLine("Select the index of the string list: ");
            int listIndex = Convert.ToInt32(Console.ReadLine());
            if (listIndex < 8 && listIndex >= 0)
            {
                Console.WriteLine(stringList[listIndex]);
            }
            else
            {
                Console.WriteLine("Sorry there is no element at the index you have selected.");
            }

            Console.ReadLine();
        }
        
    }
