using System;

namespace IfElseExamplePayRate
{
    class Program
    {
        //Write a program that prompts the user for an hourly pay rate. 
        //If the value entered is less than $7.50 or greater than $49.00, display an error message, 
        //otherwise display a message indicating that the rate is okay.

        static void Main()
        {
            Console.WriteLine("Please enter the hourly pay rate: ");
            double payRate = double.Parse(Console.ReadLine());

            if(payRate < 7.50 || payRate > 49.00)
            {
                Console.WriteLine("Invalid pay rate");
            }
            else
            {
                Console.WriteLine("The pay rate is OK");
            }
        }
    }
}
