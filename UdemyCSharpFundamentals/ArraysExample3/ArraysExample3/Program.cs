﻿using System;

namespace ArraysExample3
{
    class Program
    {
        static void Main()
        {
            /*
             * 
             *  Create a game similar to Hangman in which a player guesses
                letters to try to replicate a hidden word. Store at least eight
                words in an array, and randomly select one to be the hidden
                word. Initially, display the hidden word using
                asterisks to represent each letter. Allow the user to guess letters
                to replace the asterisks in the hidden word until the user
                completes the entire word. If the user guesses a letter that is
                not in the hidden word, display an appropriate message. If
                the user guesses a letter that appears multiple times in the
                hidden word, make sure that each correct letter is placed.
             * 
             *  ----HINT----
             *  You will need to know about strings internal array
             *  strings Contains method
             *  strings Remove method
             *  strings Insert method
             *  strings Length property
             * 
             * */

            //Get random word
            string[] words = { "jump", "programming", "sky", "pictures", "river", "start", "grass", "google" };

            Random random = new Random();
            int randomIndex = random.Next(0, 8);

            string selectedWord = words[randomIndex];
            string hiddenWord = "";
            for(int i = 0; i < selectedWord.Length; i++)
            {
                hiddenWord += "*";
            }
            //Console.WriteLine(hiddenWord);

            //Guessing stuff
            while (hiddenWord.Contains("*"))
            {
                Console.WriteLine("Word {0}:", hiddenWord);
                Console.WriteLine("Guess a letter >> ");
                char letter = char.Parse(Console.ReadLine());
                bool containsLetter = false;
                for(int i = 0; i < selectedWord.Length; i++)
                {
                    if (selectedWord[i] == letter)
                    {
                        hiddenWord = hiddenWord.Remove(i, 1);//jump //j***
                        hiddenWord = hiddenWord.Insert(i, letter.ToString());
                        containsLetter = true;
                    }
                    if(containsLetter == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Yes! {0} is in the word", letter);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, {0} is not in the word", letter);
                    }
                    Console.ResetColor();
                }

                //you won
                Console.WriteLine("Congratulations! You win! The word was {0}", selectedWord);
            }
        }
    }
}
