using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill234_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            bool validAge= false;
            
            Console.WriteLine("What is your age in years?");
            while (!validAge)
            {
                try
                {
                    int age = Convert.ToInt32(Console.ReadLine());
                    age = -age;
                    int yearOfBirth = now.AddYears(age).Year;
                    if (age > 0)
                    {
                        Console.WriteLine("You can not be negitive years old, Please enter a real age: ");
                    }
                    else if (age == 0)
                    {
                        Console.WriteLine("Wow you were born this year({0})! You must be a pretty smart baby to be using a computer!", yearOfBirth);
                        validAge = true;
                    }
                    else
                    {
                        Console.WriteLine("Your year of Birth is {0}.", yearOfBirth);
                        validAge = true;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("You must enter your age in integer form, if you are twenty five years of age please enter 25: ");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "\nPlease try again: ");
                }
            }
            Console.ReadLine();
        }
    }
}
