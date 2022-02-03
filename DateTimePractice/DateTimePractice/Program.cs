using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            Console.WriteLine("Please input a number");
            int usernum = Convert.ToInt32(Console.ReadLine());
            TimeSpan time = new TimeSpan(0, usernum, 0, 0);
            DateTime combined = date.Add(time);
            Console.WriteLine(combined);
        }
    }
}
