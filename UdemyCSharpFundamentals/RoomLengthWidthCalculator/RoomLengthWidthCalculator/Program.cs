using System;

namespace RoomLengthWidthCalculator
{
    class Program
    {
        //write a program that asks the user for the length and width of the room. 
        //Define a constant that represents the price of carpeting per square foot. 
        //Compute and display the cost of carpeting the room. 

        static void Main()
        {
            const double per_square_foot = 5.50;

            Console.WriteLine("Enter the Length of the room: ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Width of the room: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double price = area * per_square_foot;

            Console.WriteLine("The price to carpet this {0} by {1} room is {2:C}", length, width, price);
        }
    }
}
