using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise3
{
    class Program
    {
        /*
         *  Create a method named Sum() that accepts any number of
            integer parameters and displays their sum. Write a Main()
            method that demonstrates the Sum() method works correctly
            when passed one, three, or five integers, or an array of ten
            integers
         * 
         * */
        static void Main(string[] args)
        {
            Sum(3);
            Sum(3, 6, 9);
            Sum(3, 6, 9, 12, 15);

            int[] myArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Sum(myArray);
        }

        public static void Sum(params int[] myArray)
        {
            int sum = 0;
            for(int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}
