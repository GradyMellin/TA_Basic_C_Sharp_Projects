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
                Id = 1,
                isActivelyEmployed = true
            };
            Employee grady = new Employee()
            {
                FirstName = "Grady",
                LastName = "Mellin",
                Id = 1,
                isActivelyEmployed = true
            };

            sample.SayName();
            sample.Quit();
            Console.WriteLine(grady == sample);

            IQuittable sample2 = new Employee();

            Console.ReadLine();
        }
    }
}
