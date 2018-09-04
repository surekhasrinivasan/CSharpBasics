using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        //Method Overloading 

        static void Main(string[] args)
        {
            Add(5, 6);
            Add("Hello", "World");
            Add(4.7, 8.6);
        }

        //Add method with integer data type parameters 
        public static void Add(int x, int y)
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }

        //Add method with string data type parameters
        public static void Add(string x, string y)
        {
            string answer = x + " " + y;
            Console.WriteLine(answer);
        }

        //Add method with double data type parameters
        public static void Add(double x, double y)
        {
            double answer = x + y;
            Console.WriteLine(answer);
        }
    }
}
