using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>()
            {
            new Employee() { firstName = "Joe", lastName = "Walker", id = 1 },
           new Employee() { firstName = "Jack", lastName = "Cameron", id = 2 },
             new Employee() { firstName = "Joe", lastName = "Martell", id = 3 },
            new Employee() { firstName = "Ralph", lastName = "Ecker", id = 4 },
            new Employee() { firstName = "Amanda", lastName = "Young", id = 5 },
            new Employee() { firstName = "John", lastName = "Kramer", id = 6 },
            new Employee() { firstName = "Mark", lastName = "Hoffman", id = 7 },
            new Employee() { firstName = "David", lastName = "Tapp", id = 8 },
            new Employee() { firstName = "John", lastName = "Murphy", id = 9 },
            new Employee() { firstName = "Clarke", lastName = "Fruits", id = 10 },
            new Employee() { firstName = "James", lastName = "Hamilton", id = 11 },

            };
            List<Employee> JoeList = new List<Employee>();
            foreach (Employee name in employee)
            {
                if (name.firstName == "Joe")
                {
                    JoeList.Add(name);
                    Console.WriteLine("For Each People named Joe: " + name.firstName);
                }
            }

            List<Employee> JoeList2 = new List<Employee>();
            JoeList2 = employee.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee person in JoeList2)
            {
                Console.WriteLine("Lambda People named Joe: " + person.firstName );
            }
            List<Employee> Employeelist2 = new List<Employee>();
            Employeelist2 = employee.Where(x => (x.id > 5)).ToList();
            foreach (Employee person in Employeelist2)
            {
                Console.WriteLine(person.firstName + " " +person.lastName + " has the ID of "+ person.id);
            }



        }
    }
}
