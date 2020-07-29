using System;
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
        

        public void Quit()
        {
            Console.WriteLine("I Quit!");
            this.isActivelyEmployed = false;
        }
    }

}
