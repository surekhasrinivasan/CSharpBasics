using System;
using System.Threading;

class Program
{
    static void Main()
    {
        //Different data types 
        int number = 5;
        Console.WriteLine(number);

        string str = "Hello World!";
        Console.WriteLine(str);

        char letter = 's';
        Console.WriteLine(letter);

        bool isEqual = true;
        Console.WriteLine(isEqual);

        float mathPi = 3.14F;
        Console.WriteLine(mathPi);

        double mathPinum = 3.14;
        Console.WriteLine(mathPinum);

        Thread.Sleep(5000);
    }
}

