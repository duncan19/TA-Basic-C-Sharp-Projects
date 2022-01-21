using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please chose a number that you  wish to multiply by 2");
            //Maths userNum = new Maths();
            int userInput = Convert.ToInt32(Console.ReadLine());
            float decimalValue = 0.0f;
            Console.WriteLine("Please chose a decimal number you wish to multiply by 3");
            decimalValue = Single.Parse(Console.ReadLine());
            Console.WriteLine("Please input a string number you wish to multiply by 2");
            string userString = Console.ReadLine();


            Calc calc = new Calc();
            Console.WriteLine(calc.Mult(userInput));
            Console.WriteLine(calc.Mult(decimalValue));
            Console.WriteLine(calc.Mult(userString));


        }


    }
}
