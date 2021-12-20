using System;

namespace mathProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Enter your hourly rate:");
            decimal decimalVal1;
            decimal decimalWeek1;
            decimal person1Week;
            decimal weeks = 52.1429m;
            decimal person1Anual;
            decimalVal1 = System.Convert.ToDecimal(Console.ReadLine());
            //int rate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Hours worked per week:");
            decimalWeek1 = System.Convert.ToDecimal(Console.ReadLine());
            person1Week =(decimalVal1 * decimalWeek1);
            person1Anual = (person1Week * weeks);

            Console.WriteLine("Person 2");
            Console.WriteLine("Enter your hourly rate:");
            decimal decimalVal2;
            decimal decimalWeek2;
            decimal person2Week;
            decimal person2Anual;
            decimalVal2 = System.Convert.ToDecimal(Console.ReadLine());
            //int rate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Hours worked per week:");
            decimalWeek2 = System.Convert.ToDecimal(Console.ReadLine());
            person2Week = (decimalVal2 * decimalWeek2);
            person2Anual = (person2Week * weeks);

            Console.WriteLine("Person one makes $" + person1Anual + " per year");
            Console.WriteLine("Person two makes $" + person2Anual + " per year");
            bool whoMakesMore = person1Anual > person2Anual;
            Console.WriteLine("it is " + whoMakesMore + " that person one makes more per year");
        }
    }
}
