using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill230_var_const
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string constant = "This is a constant";
            var number = 5;
            Person test = new Person();
            Console.WriteLine(test.Name);
            Console.ReadLine();
        }
    }

    public class Person
    {
        public Person() : this("Joe Dirt") { }
        public Person(string name) { Name = name; }
        public string Name { get; set; }
    }
}