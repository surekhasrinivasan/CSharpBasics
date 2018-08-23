using System;

namespace IfElseExampleRandomNum
{
    class Program
    {
        static void Main()
        {
            /*
             * Write a program that generates a random number between 1 and 10. Ask a user
             * to guess the random number, then display the random number and a message
             * indicating whether the user's guess was too high, too low, or correct.
             * 
             * ------HINT-------
             * You can create a random number that is at least min but less than max using the following statements
             * Random randomGenerator = new Random();
             * int randomNumber = randomGenerator.Next(min,max);  1, 11
             * */

            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);

            Console.WriteLine("Enter your guess number: ");

            int userGuess = int.Parse(Console.ReadLine());

            Console.WriteLine("The random number was {0}", randomNumber);

            if(userGuess < randomNumber)
            {
                Console.WriteLine("Your guess was too low");
            }
            else if(userGuess > randomNumber)
            {
                Console.WriteLine("Your guess was too high");
            }
            else
            {
                Console.WriteLine("Your guess was correct");
            }
        }
    }
}
