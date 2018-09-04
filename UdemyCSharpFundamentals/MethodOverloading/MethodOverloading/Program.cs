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
        }

        //Add method with integer data type parameters 
        public static void Add(int x, int y)
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }
    }
}
