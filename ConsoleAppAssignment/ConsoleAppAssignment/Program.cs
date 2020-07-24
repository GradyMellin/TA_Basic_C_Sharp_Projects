using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] myArray = { "base ", "base ", "base ", "base ", "base ", "base ", "base ", "base ", "base ", "base " };
            //Console.WriteLine("Please enter a short amount of text");
            //string addOn = Console.ReadLine();
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = myArray[i] + addOn;
            //}
            //for (int j = 0; j < myArray.Length; j++)
            //{
            //    Console.WriteLine(myArray[j]);
            //}

            //int k = 0;

            //////////Infinite loop
            //while (k >= 0)
            //{
            //    Console.WriteLine(k);
            //    k++;
            //}
            /////////Infinite loop that will always execute at least once
            //do
            //{
            //    Console.WriteLine(k);
            //    k++;
            //}
            //while (k > 0);

            ////////// loop using the < operator
            //while (k < 100)
            //{
            //    Console.WriteLine(k);
            //    k++;
            //}

            ////////// loop using the <= operator
            //while (k <= 100)
            //{
            //    Console.WriteLine(k);
            //    k++;
            //}

            ////////Unique List
            //List<string> uniqueList = new List<string>() {"Aa", "Bb", "Cc", "Dd", "Ee", "Ff", "Gg", "Hh", "Ii", "Jj", "Kk", "Ll", "Mm", "Nn", "Oo", "Pp", "Qq", "Rr", "Ss", "Tt", "Uu", "Vv", "Ww", "Xx", "Yy", "Zz"};
            //Console.WriteLine("Pick a letter to see what elements contain that letter");
            //string letter = Console.ReadLine();
            //bool notInList = true;
            //foreach (string element in uniqueList)
            //{
            //    if (element.Contains(letter))
            //    {
            //        Console.WriteLine("The element containing the letter (" + letter + ") is at index " + uniqueList.IndexOf(element));
            //        notInList = false;
            //        break;
            //    }
            //}
            //if (notInList == true)
            //{
            //    Console.WriteLine("The list does not contain the letter (" + letter + ").");
            //}
            ////////// not unique list
            //////// diplicate words in the list
            ///
            List<string> identicalList = new List<string>() { "the", "cat", "in", "the", "hat", "was", "very", "fat","very", "fat"};
            //Console.WriteLine("Please type a word you would like to search for in the list: ");
            //string word = Console.ReadLine();
            //bool notInList = true;

            //foreach (string e in identicalList)
            //{
            //    for (int i = 0; i < identicalList.Count; i++)
            //    {
            //        string e2 = identicalList[i];
            //        if (e.Contains(identicalList[i]) && identicalList.IndexOf(e) != i)
            //        {
            //            Console.WriteLine("There are identical elements at the indices(" + identicalList.IndexOf(e) + ") and (" + i + ").");
            //        }
            //    }
            //    if (e.Contains(word))
            //    {
            //        Console.WriteLine("The element containing the letter (" + word + ") is at index " + identicalList.IndexOf(e));
            //        notInList = false;                   
            //    }
            //}
            //if (notInList == true)
            //{
            //    Console.WriteLine("The list does not contain the letter (" + word + ").");
            //}
            List<string> checkList = new List<string> { };

            foreach(string e in identicalList)
            {
                if (checkList.Contains(e))
                {
                    Console.WriteLine("This element is (" + e + "), and it has already appeared in the list.");
                }
                else
                {
                    Console.WriteLine("This element is (" + e + "), and it has not appeared yet in the list.");
                    checkList.Add(e);
                }
            }




            Console.ReadLine();
        }
    }
}
