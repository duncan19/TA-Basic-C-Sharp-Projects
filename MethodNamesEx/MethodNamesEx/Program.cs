using System;

namespace MethodNamesEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Employee employee = new Employee();
            Console.WriteLine("Please enter your first name");
            person.NameF = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            person.NameL = Console.ReadLine();
            employee.SayName();
        }
    }
}
