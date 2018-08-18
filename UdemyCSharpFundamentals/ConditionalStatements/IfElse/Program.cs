using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please input your first number");
        int firstNumber = int.Parse(Console.ReadLine());

        //Console.WriteLine("Please input your second number");
        //int secondNumber = int.Parse(Console.ReadLine());

        //if(firstNumber < secondNumber && firstNumber == 5)
        //{
        //    Console.WriteLine("The number {0} is smaller than {1}", firstNumber, secondNumber);
        //}
        //else
        //{
        //    Console.WriteLine("The number {1} is smaller than {0}", firstNumber, secondNumber);
        //}

        if (firstNumber % 2 == 0 && firstNumber % 3 == 0 && firstNumber % 5 == 0)
        {
            Console.WriteLine("The number {0} is divisible by 2, 3, 5 without a remainder.", firstNumber);
        }
        else
        {
            Console.WriteLine("The number {0} is NOT divisible by 2, 3, 5 without a remainder.", firstNumber);
        }
    }
}

