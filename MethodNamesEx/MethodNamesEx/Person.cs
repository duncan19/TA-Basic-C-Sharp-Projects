using System;
using System.Collections.Generic;
using System.Text;

namespace MethodNamesEx
{
    public class Person 
    {
        string name = "sample";
        string namel = "student";
        private string nameF;
        public string NameF
        {
            get => nameF;
            set => nameF = value;
        }
        private string nameL;
        public string NameL
        {
            get => nameL;
            set => nameL = value;
        }
        public  void SayName()
        {
            Console.WriteLine("Name: "+ name + " " + namel);
        }
    }
}
