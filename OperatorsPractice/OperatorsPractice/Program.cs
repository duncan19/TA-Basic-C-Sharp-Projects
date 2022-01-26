using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee1.Id = 2;
            employee2.Id = 2;
            Console.WriteLine(employee1.Id == employee2.Id);
            Console.WriteLine(employee1.Id != employee2.Id);


        }
    }
}
