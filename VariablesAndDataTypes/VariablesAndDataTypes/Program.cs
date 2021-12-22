using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';

            decimal moneyInnBank = 100.5m;

            double heightInCentimeters = 211.30202091;

            float secondsLeft = 2.63f;

            short tempatureOnMars = -341;

            string myName = "Duncan";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);

            Console.WriteLine(rainingStatus);
        }
    }
}
