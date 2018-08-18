using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Please input your first number");
        int firstNumber = int.Parse(Console.ReadLine());

        //Console.WriteLine("Please input your second number");
        //int secondNumber = int.Parse(Console.ReadLine());

        //if (firstNumber < secondNumber && firstNumber == 5)
        //{
        //    Console.WriteLine("The number {0} is smaller than {1}", firstNumber, secondNumber);
        //}
        //else if(firstNumber == secondNumber)
        //{
        //    Console.WriteLine("The first number and second number are equal!");
        //}
        //else
        //{
        //    Console.WriteLine("The number {1} is smaller than {0}", firstNumber, secondNumber);
        //}

        //Usage of if else if 
        if (firstNumber == 0)
        {
            Console.WriteLine("Zero");
        }
        else if(firstNumber == 1)
        {
            Console.WriteLine("One");
        }
        else if (firstNumber == 2)
        {
            Console.WriteLine("Two");
        }
        else if (firstNumber == 3)
        {
            Console.WriteLine("Three");
        }
        else if (firstNumber == 4)
        {
            Console.WriteLine("Four");
        }
        else if (firstNumber == 5)
        {
            Console.WriteLine("Five");
        }
        else if (firstNumber == 6)
        {
            Console.WriteLine("Six");
        }
        else if (firstNumber == 7)
        {
            Console.WriteLine("Seven");
        }
        else if (firstNumber == 8)
        {
            Console.WriteLine("Eight");
        }
        else if (firstNumber == 9)
        {
            Console.WriteLine("Nine");
        }
        else
        {
            Console.WriteLine("The number {0} is bigger than 9", firstNumber);
        }
    }
}

