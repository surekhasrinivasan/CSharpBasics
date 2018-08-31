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
            int answer = Add(100, 34);
            Console.WriteLine(answer);
        }

        //access modifiers public private, static, return type, methodname(parameters)
        public static void DisplayMessage()
        {
            Console.WriteLine("Hello World!");
        }

        //Adding two numbers 
        public static int Add(int num1, int num2)
        {
            int answer = num1 + num2;
            //Console.WriteLine(answer);
            return answer;
        }
    }
}
