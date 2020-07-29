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
            Employee sample = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                isActivelyEmployed = true
            };

            sample.SayName();
            sample.Quit();

            IQuittable sample2 = new Employee();

            Console.ReadLine();
        }
    }
}
