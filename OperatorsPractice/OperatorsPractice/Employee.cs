using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsPractice
{

    public class Employee
    {
        public int Id { get; set; }


        public static bool operator== (Employee employee ,Employee employee2 )
        {
            if(employee.Id.Equals(employee2.Id))
            {
                Console.WriteLine("Overloaded ==");
                return true;
            }
            else
            {
                return false;
            }    
           
        }
        public static bool operator!= (Employee employee, Employee employee2)
        {
            if (employee.Id != employee2.Id)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Overloaded !=");
                return true;
            }
        }

    }
}
