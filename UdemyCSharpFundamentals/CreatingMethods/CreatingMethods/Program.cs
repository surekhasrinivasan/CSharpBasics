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
        }

        //access modifiers public private, static, return type, methodname(parameters)
        public static void DisplayMessage()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
