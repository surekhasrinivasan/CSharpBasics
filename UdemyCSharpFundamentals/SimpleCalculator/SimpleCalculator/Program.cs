using System;

namespace SimpleCalculator
{
    class Program
    {
        //Simple Calculator - Reads two integers from the user, does addition, subtraction,multiplication and Division operation. 
        //Prints the result on console. 

        static void Main()
        {
            Console.WriteLine("Please enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            // Calculates the sum of two integers

            int answer = firstNumber + secondNumber;
            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, answer);

            //Calculates the difference between firstNumber and secondNumber

            int difference = firstNumber - secondNumber;
            Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, difference);

            //Calulates the product of two integers

            int product = firstNumber * secondNumber;
            Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, product);

            //Calculates the result of dividing two integers

            int result = firstNumber / secondNumber;
            Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);
        }
    }
}
