using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1\nHourly rate:");
            string s_p1_HrRate = Console.ReadLine();
            decimal p1_HrRate = Convert.ToDecimal(s_p1_HrRate);
            Console.WriteLine("Hours worked Per Week:");
            string s_p1_HrsWorked = Console.ReadLine();
            int p1_HrsWorked = Convert.ToInt32(s_p1_HrsWorked);
            decimal p1_annualSalary = p1_HrRate * p1_HrsWorked * 52;

            Console.WriteLine("Person 2\nHourly rate:");
            string s_p2_HrRate = Console.ReadLine();
            decimal p2_HrRate = Convert.ToDecimal(s_p2_HrRate);
            Console.WriteLine("Hours worked Per Week:");
            string s_p2_HrsWorked = Console.ReadLine();
            int p2_HrsWorked = Convert.ToInt32(s_p2_HrsWorked);
            decimal p2_annualSalary = p2_HrRate * p2_HrsWorked * 52;

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(p1_annualSalary);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(p2_annualSalary);
            Console.WriteLine("Does Person 1 make more money that Person 2?");
            bool salCompare = p1_annualSalary > p2_annualSalary;
            Console.WriteLine(salCompare);
            Console.ReadLine();

        }
    }
}
