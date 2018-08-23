using System;

namespace IfElseExampleMowingFeeCalc
{
    class Program
    {
        static void Main()
        {
            /* Write a program for a lawn-mowing service. The lawn-mowing season lasts 20 weeks.
             * The weekly fee for mowing a lot under 400 square feet is $25.
             * The fee for a lot that is 400 square feet or more, but under 600 square feet, is $35 per week.
             * The fee for a lot that is 600 square feet or over is $50 per week.
             * Prompt the user for the length and width of a lawn, and then display the weekly mowing fee, 
             * as well as the total fee for the 20 - week season.
             * */

            Console.WriteLine("Enter the length of the yard: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the yard: ");
            int width = int.Parse(Console.ReadLine());

            int weeklyPrice;

            int totalSquareFeet = length * width;

            if(totalSquareFeet < 400)
            {
                weeklyPrice = 25;                
            }
            else if(totalSquareFeet >= 400 && totalSquareFeet < 600)
            {
                weeklyPrice = 35;
            }
            else 
            {
                weeklyPrice = 50;
            }

            Console.WriteLine("The weekly fee is {0}", weeklyPrice);
            Console.WriteLine("The 20 week season fee is {0}", weeklyPrice * 20);
        }
    }
}