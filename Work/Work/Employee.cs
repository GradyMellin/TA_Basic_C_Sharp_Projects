using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public bool isActivelyEmployed { get; set; }
        
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            bool compare = employee1.Id == employee2.Id;
            return compare;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
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
