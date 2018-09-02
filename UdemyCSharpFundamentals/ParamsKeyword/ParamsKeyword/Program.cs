using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeyword
{
    class Program
    {
        //Params Keyword

        static void Main(string[] args)
        {
            //param keyword stands for parameter array and its deals with passing an array into a function
            int[] myArray = { 5, 6, 7, 8, 9, 10 };
            PrintArray(myArray);
        }    
        
        //function that prints all the values of an array 
        public static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
