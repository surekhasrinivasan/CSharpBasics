using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise2
{
    class Program
    {
        /* 
         *  Create a console-based program whose Main() method
            prompts the user for an integer value and, in turn, passes
            the value to a method that squares the number and to
            a method that cubes the number. The Cube() method
            should call the Square() method. The Main() method
            displays the results returned from each of the other methods.
         * 
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int squared = Square(number);
            Console.WriteLine("The square of {0} is: {1}", number, squared);
        }

        public static int Square(int number)
        {
            int answer = number * number;
            return answer;
        }        
    }
}
