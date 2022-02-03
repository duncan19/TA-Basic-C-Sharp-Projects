using System;

namespace ConstructorPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const int age = 20;
            Console.WriteLine("What is your name?");
            var username = Console.ReadLine();
            Person person = new Person(username);


        }
    }
}
