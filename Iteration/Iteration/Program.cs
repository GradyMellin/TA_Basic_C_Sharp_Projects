using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 92, 83, 72, 69, 57, 99, 88, 77, 83 };

            //for( int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] >= 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}

            //string[] names = { "Grady", "Nicole", "Robinson", "Hunter", "Alex", "Cian", "Renee", "Billy" };

            //for( int j = 0; j < names.Length; j++)
            //{
            //    if (names[j].Contains("a"))
            //    {
            //        Console.WriteLine("There is an a in the name " + names[j]);
            //    }
            //}

            List<int> testScores = new List<int>();
            testScores.Add(98);
            testScores.Add(84);
            testScores.Add(73);
            testScores.Add(94);
            testScores.Add(82);
            testScores.Add(88);
            testScores.Add(69);
            List<int> passScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score >= 85)
                {
                    Console.WriteLine("Passing test score: " + score);
                    passScores.Add(score);
                }
            }

            Console.WriteLine(passScores.Count);

            //List<string> names = new List<string>() { "Grady", "Nicole", "Robinson", "Hunter", "Alex", "Cian", "Renee", "Billy" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}





            Console.ReadLine();
        }
    }
}
