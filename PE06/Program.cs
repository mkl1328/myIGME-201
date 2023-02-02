using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int turns = 8;
            int turnCounter = 0;
            bool correct = false;

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);

            //FOR DEBUG! - REMOVE FOR FINAL
            Console.WriteLine(randomNumber);

            // Give the user 8 tries to guess the number

            for(turnCounter = 0; turnCounter < turns; turnCounter++)
            {
                string sGuess = "";
                int nGuess;

                // DATA VALIDATION
                while(true)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Guess a number between 0 and 100! \n" +
                            $"     You have {8-turnCounter} guesses left");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        sGuess = Console.ReadLine();
                        nGuess = Convert.ToInt32(sGuess);

                        //Check if in between 0 and 100
                        if (nGuess >= 0 && nGuess <= 100)
                        {
                            break;
                        }
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($"{sGuess} is not between 0 and 100! Try again.");
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($"{sGuess} is not a valid guess! Try again with a number between 0 and 100");
                    }
                }

                // CASES (greater, less, correct);
                if (nGuess > randomNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"\n{nGuess} is too high.");
                }
                else if (nGuess < randomNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"\n{nGuess} is too low.");
                }
                else if (nGuess == randomNumber) 
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"\nGOOD GUESS!! {nGuess} was the number!\n" +
                        $" You only took {++turnCounter} Guesses!");
                    correct = true;
                    break;
                }

                if(turnCounter != 7)
                {
                    Console.WriteLine(" Guess again!");
                }
            }

            //Ran out of guesses
            if (correct == false)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nLooks like you're out of guesses :(" +
                    $"   The Correct answer was: {randomNumber}");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
