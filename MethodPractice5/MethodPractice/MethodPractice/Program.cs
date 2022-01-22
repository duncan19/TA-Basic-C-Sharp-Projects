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
            Calc calc = new Calc();
            int a, b;
            //Console.WriteLine("Please chose a number that you  wish to multiply by 2");
            ////Maths userNum = new Maths();
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //float decimalValue = 0.0f;
            //Console.WriteLine("Please chose a decimal number you wish to multiply by 3");
            //decimalValue = Single.Parse(Console.ReadLine());
            //Console.WriteLine("Please input a string number you wish to multiply by 2");
            //string userString = (Console.ReadLine());

            
            calc.getValues(out a, out b);
            Console.WriteLine("choose your 1st number ");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            calc.Div2(userNum1);
            Console.WriteLine("choose your 2nd number ");
            string userString = Console.ReadLine();
            calc.Mult(userNum1);
            calc.Mult(userString);
            Console.WriteLine(calc.Mult(userNum1));
            Calc.helloTest();
            //Console.WriteLine("choose your 2nd number");
            //int userNum2 = Convert.ToInt32(Console.ReadLine());
            //calc.twoNums2(userNum1, userNum2);
            //try
            //{
            //    Console.WriteLine("choose your 2nd sunber to subract from the 1st one this step is optional");
            //    int userNum2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(calc.twoNums(userNum1, userNum2));
            //}
            //catch (FormatException)
            //{
            //    int userNum2 = 0;
            //    Console.WriteLine(calc.twoNums(userNum1,userNum2));
            //}



            //Console.WriteLine(calc.Mult(userInput));
            //Console.WriteLine(calc.Mult(decimalValue));
            //Console.WriteLine(calc.Mult(userString));




        }


    }
}
