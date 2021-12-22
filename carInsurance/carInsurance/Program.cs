using System;

namespace carInsurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("have you ever had a DUI");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("how many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            if (age < 16) { Console.WriteLine("You are too young"); }
            else if (dui == true) { Console.WriteLine("You cannot have a dui"); }
            else if (tickets > 3) { Console.WriteLine("You cannot have more than 3 speeding tickets"); }
            else { Console.WriteLine("You are qualified"); }

        }
    }
}
