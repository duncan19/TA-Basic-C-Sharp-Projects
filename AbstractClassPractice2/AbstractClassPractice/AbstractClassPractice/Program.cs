using System;

namespace AbstractClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            IQuittable quittable = new Employee();


            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();
            quittable.Quit();
            

        }
    }
}
