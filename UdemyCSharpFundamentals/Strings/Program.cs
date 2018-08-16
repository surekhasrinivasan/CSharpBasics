using System;
using System.Threading;

class Program
{
    static void Main()
    {
        //Strings 
        string firstString = "C# course";
        string secondString = "for beginners!";
        string freeSpace = " ";

        //Console.WriteLine(firstString);
        //Console.WriteLine(secondString);
        
        //string concatenation 
        Console.WriteLine("I am taking my first " + firstString + freeSpace + secondString + " and I am really happy with what I am learning.");

        //using placeholders 
        Console.WriteLine("I am taking my first {0}{1}{2} and I am really happy with what I am learning.", firstString, freeSpace, secondString);
        Thread.Sleep(3000);
    }
}

