using System;

class Program
{
    //Arithmetic Operators: + - * / % ++ --

    static void Main()
    {
        int firstNumber = 20;
        int secondNumber = 7;

        int addition = firstNumber + secondNumber;
        int subtraction = firstNumber - secondNumber;
        int multiplication = firstNumber * secondNumber;
        double division = (double)firstNumber / (double)secondNumber;

        Console.WriteLine("The result of the addition is: {0}", addition);
        Console.WriteLine("The result of the subtraction is: {0}", subtraction);
        Console.WriteLine("The result of the multiplication is: {0}", multiplication);
        Console.WriteLine("The result of the division is: {0}", division);

        firstNumber++;
        Console.WriteLine("The first number when incremented it is: {0}", firstNumber);

        firstNumber--;
        firstNumber--;
        firstNumber--;
        Console.WriteLine("The first number when decremented it is: {0}", firstNumber);

        int divisionWithRemainder = firstNumber % secondNumber;
        Console.WriteLine(divisionWithRemainder);
        Console.WriteLine(17 % 2);
        Console.WriteLine(551 % 2);
    }
}

