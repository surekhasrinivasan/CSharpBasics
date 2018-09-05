using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        //Optional Parameters
        
        public static void Main(string[] args)
        {
            Add(5);
            Add(5, 5);
        }

        //To use optional parameter we use some kind of default value and this value is used if we do not supply one.
        public static void Add(int x, int y = 1)
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }
    }
}
