using System;
using System.Threading;

class Program
{
    static void Main()
    {
        //Difference between Write and WriteLine is Write, writes all in one line whereas WriteLine creates new line

        Console.Write("I am learning ");
        Console.Write("C# course ");
        Console.Write("on Udemy\n");
        Console.WriteLine();

        Console.WriteLine("I am learning ");
        Console.WriteLine("C# course ");
        Console.WriteLine("on Udemy\n");
        Console.WriteLine();

        Thread.Sleep(3000);
    }
}

