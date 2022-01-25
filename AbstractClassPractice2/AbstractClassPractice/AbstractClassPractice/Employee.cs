using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassPractice
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("The Employee's name is :");
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine(this.firstName + " "+ this.lastName +" has Quit");
        }
    }
}
