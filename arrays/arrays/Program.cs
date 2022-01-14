using System;
using System.Collections.Generic;

namespace arrays
{
    class Program
    {
        static void Main()
        {
            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);
            //intList.Remove(10);

            //List<string> stringList = new List<string>();
            //stringList.Add("Test");
            //stringList.Add("Test2");

            //Console.WriteLine(stringList[1]);
            //Console.ReadLine();

            //Console.WriteLine(intList[0]);
            //Console.ReadLine();


           int[] numArray = new int[5];
           numArray[0] = 5;
           numArray[1] = 2;
           numArray[2] = 10;
           numArray[3] = 200;
           numArray[4] = 500;

          int[] numArray1 = new int[] { 5, 3, 10, 200, 500 };

          int[] numArray2 = { 5, 2, 10, 200, 5000, 64 };

          string[] sArray = { "test", "rat", "pickle" };


            List<string> list1 = new List<string>();
            list1.Add("Test");
            list1.Add("Test2");

            Console.WriteLine("Pick an index in the  string array");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick an index in the int array");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick an index in the list");
            int number3 = Convert.ToInt32(Console.ReadLine());
            if (number > sArray.Length) { Console.WriteLine("Your number was too large, pick a index in the array");
          
            }
            else
            {
                Console.WriteLine(sArray[number]);
                Console.ReadLine();
            }
            if (number2 > numArray2.Length) { Console.WriteLine("Your number was too large, pick a index in the array"); }
            else
            {
                Console.WriteLine(numArray2[number2]);
                Console.ReadLine();
            }
            if (number3 > list1.Count) { Console.WriteLine("Your number was too large, pick a index in the list"); }
            else
            {
                Console.WriteLine(list1[number3]);
                Console.ReadLine();
            }
        }
    }
}
