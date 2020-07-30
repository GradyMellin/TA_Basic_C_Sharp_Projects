using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    public class Employee<T> : Person, IQuittable
    {
        public int Id { get; set; }
        public bool isActivelyEmployed { get; set; }
        public List<T> Things { get; set; }

        public static bool operator ==(Employee<T> employee1, Employee<T> employee2)
        {
            bool compare = employee1.Id == employee2.Id;
            return compare;
        }
        public static bool operator !=(Employee<T> employee1, Employee<T> employee2)
        {
            bool compare = employee1.Id == employee2.Id;
            return compare;
        }

        public void Quit()
        {
            Console.WriteLine("I Quit!");
            this.isActivelyEmployed = false;
        }
    }

}
