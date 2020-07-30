using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> sample = new Employee<string>()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 1,
                isActivelyEmployed = true
            };
            sample.Things = new List<string>() { "jar", "cup", "keys" };
            Employee<int> grady = new Employee<int>()
            {
                FirstName = "Grady",
                LastName = "Mellin",
                Id = 1,
                isActivelyEmployed = true
            };
            grady.Things = new List<int>() { 1, 2, 3 };
            //sample.SayName();
            //sample.Quit();
            //Console.WriteLine(grady == sample);
            //foreach(string thing in sample.Things)
            //{
            //    Console.WriteLine(thing);
            //}
            //foreach (int thing in grady.Things)
            //{
            //    Console.WriteLine(thing);
            //}
            //IQuittable sample2 = new Employee<string>();
            DayOfTheWeek day = new DayOfTheWeek();
            Console.WriteLine("Please Enter the current day of the week starting with a capital letter: ");
            try
            {
                string day1 = Console.ReadLine();
                day.Day = (Days)Enum.Parse(typeof(Days), day1);
                Console.WriteLine("Today is a " + day.Day);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter an actual day of the week.");
            }
            
            Console.ReadLine();

        }
       
    }
}
