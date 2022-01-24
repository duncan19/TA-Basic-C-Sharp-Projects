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
        }


    }
}
