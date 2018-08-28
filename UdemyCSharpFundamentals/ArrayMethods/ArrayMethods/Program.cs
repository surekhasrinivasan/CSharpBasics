using System;

namespace ArrayMethods
{
    class Program
    {
        //Useful Array Methods

        static void Main()
        {
            //Binary search method
            int[] myArray = { 10, 15, 20, 25, 30, 35, 40, 45 };
            Console.WriteLine("Enter number to check if it exists");
            int number = int.Parse(Console.ReadLine());

            int answer = Array.BinarySearch(myArray, number);
            if(answer < 0)
            {
                Console.WriteLine("The number does not exist");
            }
            else
            {
                Console.WriteLine("The numbers position in the array is {0}", answer);
            }
        }
    }
}
