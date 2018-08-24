using System;

namespace LoopsProgram2
{
    class Program
    {
        static void Main()
        {
            //Write a console based application that sums the integers from 1 to 50.

            int sum = 0; 

            for(int i = 1;i <= 50; i++)
            {
                //Console.WriteLine(i);
                sum += i;                
            }
            Console.WriteLine("The sum of integers from 1 to 50 is {0}",sum);
        }
    }
}
