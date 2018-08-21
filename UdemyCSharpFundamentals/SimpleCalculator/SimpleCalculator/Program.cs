using System;

namespace SimpleCalculator
{
    class Program
    {
        //Simple Calculator - Reads two integers from the user and adds them together. Prints the result on console. 

        static void Main()
        {
            Console.WriteLine("Please enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int answer = firstNumber + secondNumber;

            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, answer);
        }
    }
}
