using System;
using System.Collections.Generic;
using System.Text;

namespace MethodPractice
{
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
        public int Div(int number)
        {
            number = (number / 3);
            return number;
        }
        public int Sub(int number)
        {
            number = (number - 1);
            return number;
        }
        public int twoNums(int number, int number2)
        {
           int finNumber = (number - number2);
            return finNumber;
        }
        public void twoNums2(int num1, int num2)
        {
            int finNum = num1 * 2;
            Console.WriteLine(num2);

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
        public class helloTest
        {
            public static void helloM()
            {
                Console.WriteLine("Hello");
            }
            static void Main()
            {
                helloTest.helloM();
                Console.ReadKey();
            }
        }
    }
}


