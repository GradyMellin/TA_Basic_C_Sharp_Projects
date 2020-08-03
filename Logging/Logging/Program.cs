using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\Grady Mellin\Desktop\C#_course\TA_Basic_C#_Projects\log.txt", true))
            {
                file.WriteLine(number);
            }
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
