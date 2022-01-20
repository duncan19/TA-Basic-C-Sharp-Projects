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
    }
}


