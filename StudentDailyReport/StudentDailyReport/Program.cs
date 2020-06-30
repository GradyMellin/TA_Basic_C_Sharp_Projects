using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace StudentDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\n" +
                "Student Daily Report\n" + 
                "What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What Course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            string s_pageNumber = Console.ReadLine();
            short pageNumber = Convert.ToInt16(s_pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            string s_needHelp = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(s_needHelp);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string s_studyHours = Console.ReadLine();
            short studyHours = Convert.ToInt16(s_studyHours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}

