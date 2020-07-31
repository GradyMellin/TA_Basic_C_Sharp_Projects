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
                Id = 1
            };
            sample.Things = new List<string>() { "jar", "cup", "keys" };
            Employee<string> grady = new Employee<string>()
            {
                FirstName = "Grady",
                LastName = "Mellin",
                Id = 2
            };
            Employee<string> employee3 = new Employee<string>()
            {
                FirstName = "Bill",
                LastName = "Wilson",
                Id = 3
            };
            Employee<string> employee4 = new Employee<string>()
            {
                FirstName = "Bob",
                LastName = "Smith",
                Id = 4
            };
            Employee<string> employee5 = new Employee<string>()
            {
                FirstName = "Joe",
                LastName = "Shmo",
                Id = 5
            };
            Employee<string> employee6 = new Employee<string>()
            {
                FirstName = "Jerry",
                LastName = "Cherry",
                Id = 6
            };
            Employee<string> employee7 = new Employee<string>()
            {
                FirstName = "Joe",
                LastName = "Dirt",
                Id = 7
            };
            Employee<string> employee8 = new Employee<string>()
            {
                FirstName = "Donkey",
                LastName = "Kong",
                Id = 8
            };
            Employee<string> employee9 = new Employee<string>()
            {
                FirstName = "Kelly",
                LastName = "Smelly",
                Id = 9
            };
            Employee<string> employee10 = new Employee<string>()
            {
                FirstName = "Minty", 
                LastName = "Fresh",
                Id = 10
            };

            List < Employee<string>> employees = new List<Employee<string>>() { sample, grady, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };
            List<Employee<string>> joes = new List<Employee<string>>();
            foreach (Employee<string> employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            List<Employee<string>> joes2 = employees.Where(x => x.FirstName == "Joe").ToList();

            List<Employee<string>> id5 = employees.Where(x => x.Id > 5).ToList();



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

            //DayOfTheWeek day = new DayOfTheWeek();
            //Console.WriteLine("Please Enter the current day of the week starting with a capital letter: ");
            //try
            //{
            //    string day1 = Console.ReadLine();
            //    day.Day = (Days)Enum.Parse(typeof(Days), day1);
            //    Console.WriteLine("Today is a " + day.Day);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Please enter an actual day of the week.");
            //}

            Console.ReadLine();

        }
       
    }
}
