using System;

namespace TechAcademyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("====================");
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            //Console.WriteLine(course);
            Console.WriteLine("What page number?");
            int page = Convert.ToInt32(Console.ReadLine()); 
            //Console.WriteLine(page);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string help = Console.ReadLine();
            //Console.WriteLine(help);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experience = Console.ReadLine();
            //Console.WriteLine(experience);
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            //Console.WriteLine(feedback);
            Console.WriteLine("How many hours did you study today?");
            int studyTime = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(studyTime);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine(); // or press ctrl+F5 and comment out this line. This will not compile an exe
        }
    }
}
