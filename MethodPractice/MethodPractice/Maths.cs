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
    }
}


