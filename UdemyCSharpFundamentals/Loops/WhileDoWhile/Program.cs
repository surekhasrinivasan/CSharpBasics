using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please input the first number:");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input the end number:");
        int endNumber = int.Parse(Console.ReadLine());

        while(firstNumber <= endNumber)
        {
            Console.WriteLine(firstNumber);
            firstNumber++;
        }
    }
}

