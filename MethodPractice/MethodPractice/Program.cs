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
            Console.WriteLine("Please chose a number that you  wish to be divided by 3 multiplied by 2 and than subracted by 1 ");
            //Maths userNum = new Maths();
            int userInput = Convert.ToInt32(Console.ReadLine());
            Calc calc = new Calc();
            Console.WriteLine(calc.Mult(userInput));
            Console.WriteLine(calc.Div(userInput));
            Console.WriteLine(calc.Sub(userInput));
        }


    }
}
