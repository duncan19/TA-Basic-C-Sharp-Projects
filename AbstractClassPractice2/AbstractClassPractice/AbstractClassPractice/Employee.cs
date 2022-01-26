using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassPractice
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("The Employee's name is :" +firstName);
            
        }
        public void Quit()
        {
            Console.WriteLine("I Quit");
        }
    }
}
