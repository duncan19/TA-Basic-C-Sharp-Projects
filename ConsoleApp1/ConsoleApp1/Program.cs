using System;

namespace myConsoleProjects.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to package express. Please follow instructions");
            Console.WriteLine("What is your package's weight?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50) { Console.WriteLine("Your package cannoot be shipped by us it is too heavy. "); }
            else
            {
                Console.WriteLine("What is your package's width?");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your package's height?");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your package's length?");
                int length = Convert.ToInt32(Console.ReadLine());
                if ((width > 50) || (height > 50) || (length > 50)) { Console.WriteLine("Your package cannoot be shipped by us it is too large. "); }
                else
                {
                    int quote = ((width * height * length)*weight)/100;
                    Console.WriteLine("it will cost $" + quote);
                }
            }
        }
    }
}