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

            //Named parameter 
            Add(5, z : 5);
        }

        //To use optional parameter we use some kind of default value and this value is used if we do not supply one.

        //Named arguments allow us to specify what parameter we are talking about. first num goes to first parameter etc. 
        public static void Add(int x, int y = 1, int z = 2)
        {
            int answer = x + y + z;
            Console.WriteLine(answer);
        }
    }
}
