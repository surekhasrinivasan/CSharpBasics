using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World");

        //Console.WriteLine("What is your name?");
        //Console.WriteLine();
        //string name = Console.ReadLine();
        //Console.WriteLine("My name is: " + name);

        //Console.WriteLine("How old are you?");
        //int age = int.Parse(Console.ReadLine());
        //Console.WriteLine(age);

        int age = 0;

        while (true)
        {
            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());

            if (age <= 10 && age >= 1)
            {
                break;
            }
            Thread.Sleep(2000);

            Console.WriteLine("Please enter the age between 1 and 10");
        }
            Console.WriteLine(age);        
    }
}

