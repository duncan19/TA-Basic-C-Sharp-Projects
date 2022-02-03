using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorPractice
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name) : this(name, 10)
        {
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            
        }
    }
}
