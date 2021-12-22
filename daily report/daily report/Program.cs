using System;

namespace daily_report
{
    class Program
    {
        static void Main()
        {
            //Gathering info though console write expressions 
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your current course you are on?");
            string course = Console.ReadLine();
            Console.WriteLine("what page number are you on");
            int page = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("do you need help with anything?");
            bool help = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiances you would like to share?");
            string positive = Console.ReadLine();
            Console.WriteLine("is there any other feedback you would like to provide?");
            string feedback = Console.ReadLine();
            Console.WriteLine("how many hours did you study today?");
            string hours = Console.ReadLine();
            //printing feedback back out to them
            Console.WriteLine("Hello " + name + " you said you are currently on page " + page + " of the " + course + " course and when asked about help you said " + help + " when asked about feed beack you said" + feedback + " and when asked about positive experiances you said " + positive + " and overall you spent " + hours + " hours studying");
            Console.WriteLine("“Thank you for your answers. An Instructor will respond to this shortly. Have a great day!”");
        }
    }
}
