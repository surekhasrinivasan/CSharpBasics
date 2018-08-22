using System;

namespace MinutesToHourMinutesCalculation
{
    class Program
    {
        static void Main()
        {
            //write a program that asks the user to enter a total amount of time in minutes only. 
            //Print to the console the same amount of time in hours and minutes.

            Console.WriteLine("Enter total amount of time in minutes only: ");
            int totalTimeInMinutes = int.Parse(Console.ReadLine());

            int hours = totalTimeInMinutes / 60;
            int remainingMinutes = totalTimeInMinutes % 60;

            Console.WriteLine("{0} minutes is equal to {1} hours and {2} minutes.", totalTimeInMinutes, hours, remainingMinutes);
        }
    }
}
