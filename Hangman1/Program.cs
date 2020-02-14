using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Challenge_ConsoleGame
{
    public class Hangman
    {
        static void Main(string[] args)
        {
            //Formatting
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                                  ************************    ");
            Console.WriteLine("                                  *  Welcome to HANGMAN! *    ");
            Console.WriteLine("                                  ************************    ");

            //Taking in our "Secret Word
            Console.WriteLine("Player 1, Enter a word: ");

            string secretWord;
            secretWord = Convert.ToString(Console.ReadLine());

            //Taking in player name
            Console.Clear();
            Console.WriteLine("                                  ************************    ");
            Console.WriteLine("                                  *  Welcome to HANGMAN! *    ");
            Console.WriteLine("                                  ************************    ");
            Console.Write("Player 2, enter your Name: ");

            string name;
            name = Convert.ToString(Console.ReadLine());
            name = name.ToUpper();

            //Greeting and start game
            Console.Clear();
            Console.WriteLine("                                  ************************    ");
            Console.WriteLine("                                  *  Welcome to HANGMAN! *    ");
            Console.WriteLine("                                  ************************    ");
            Console.WriteLine("Welcome, " + name + ", Good Luck!");
            Console.WriteLine("\n\n");

            char[] firstArray = new char[secretWord.Length];
            for (int l = 0; l < secretWord.Length; l++)
                firstArray[l] = '*';
            Console.WriteLine(firstArray);
            Console.WriteLine("\n\n");
            char[] resultArray = new char[secretWord.Length];
            int lives = 7;
            int correctGuesses = 0;
            string checkAnswer = resultArray.ToString();
            for (int i = 0; i < secretWord.Length; i++)
                resultArray[i] = '*';
            while (lives > 0 && correctGuesses < secretWord.Length)
            {
                // Get their guessed letter
                Console.WriteLine("Please guess a letter");
                char guessedLetter = char.Parse(Console.ReadLine());
                // Check to see if we need to replace any letters
                if (secretWord.Contains(guessedLetter))
                {
                    // Replace all matching letters
                    for (int i = 0; i < secretWord.Length; i++)
                    {
                        if (guessedLetter == secretWord[i])
                        {
                            resultArray[i] = guessedLetter;
                            correctGuesses++;
                        }
                    }
                }
                // If we don't need to replace any letters, dock a life
                else
                {
                    lives--;
                    Console.WriteLine("You have " + lives + " lives remaining");
                }
                // If the target word matches the guessed word, then break out
                Console.WriteLine(resultArray);
            }
            //
            if (lives == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("GAME OVER!!");
                Console.WriteLine("The correct word was: " + secretWord);
                Console.ReadLine();
            }
            if (correctGuesses == secretWord.Length)
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CONGRATULATIONS, YOU WON!");
            Console.ReadLine();
        }
    }
}

