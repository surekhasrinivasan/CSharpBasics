using System;

namespace LoopsProgram3
{
    class Program
    {
        static void Main()
        {
            /* * EDIT TO USE LOOPS
             * 
             * Write a program that generates a random number between 1 and 10. Ask a user
             * to guess the random number, then display the random number and a message
             * indicating whether the user's guess was too high, too low, or correct.
             * 
             * ------HINT-------
             * You can create a random number that is at least min but less than max using the following statements
             * Random randomGenerator = new Random();
             * int randomNumber = randomGenerator.Next(min,max);  1, 11
             * 
             * */

            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);

            int guessNumber;
            int numberOfGuesses = 0;

            do
            {
                Console.WriteLine("Enter your guess number: ");
                guessNumber = int.Parse(Console.ReadLine());
                
                if(guessNumber < randomNumber)
                {
                    Console.WriteLine("Your guess is too low");
                }
                else if(guessNumber > randomNumber)
                {
                    Console.WriteLine("Your guess is too high");
                }
                else
                {
                    Console.WriteLine("Your guess is correct");
                }
                numberOfGuesses++;

            } while (guessNumber != randomNumber);

            Console.WriteLine("The number of guesses {0}", numberOfGuesses);
        }
    }
}
