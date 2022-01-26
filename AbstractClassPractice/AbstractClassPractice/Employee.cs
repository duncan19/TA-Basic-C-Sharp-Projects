using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassPractice
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("The Employee's name is :" +firstName + " " + lastName);
            
        }
    }
}
