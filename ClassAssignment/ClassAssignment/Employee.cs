using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class Employee : Person
    {
        public void SayName()
        {
            Console.WriteLine("Employee Name: [" + FirstName + " " + LastName + "]");
        }
        public int Id { get; set; }
    }
}
