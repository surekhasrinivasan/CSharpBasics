using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMessage();
            Add(10, 34);
            Add(300, 34);
        }

        //access modifiers public private, static, return type, methodname(parameters)
        public static void DisplayMessage()
        {
            Console.WriteLine("Hello World!");
        }

        //Adding two numbers 
        public static void Add(int num1, int num2)
        {
            int answer = num1 + num2;
            Console.WriteLine(answer);
        }
    }
}
