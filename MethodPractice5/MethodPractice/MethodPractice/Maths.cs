using System;
using System.Collections.Generic;
using System.Text;

namespace MethodPractice
{
    public static class Calc2
    {
        public static string Color = "red";
    }
    class Calc
    {
        public int Mult(int number)
        {
            number = (number * 2);
            return number;
        }
        public float Mult(float number)
        {
            number = (number * 3);
            return number;
        }
        public int Mult(string number)
        {

           int firstNum = Convert.ToInt32(number);
           return firstNum * 4;
           
        }

        public void Div2(int number)
        {
            Console.WriteLine(number);
            int finNum = number / 2;
            Console.WriteLine(finNum);
        }
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
            public void getValues(out int x, out int y)
            {
                Console.WriteLine("Enter the first number: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                y = Convert.ToInt32(Console.ReadLine());
            }
        
    }
}


