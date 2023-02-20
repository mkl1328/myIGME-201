using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace UnitTest_q4
{
    // Class: Program
    // Author: Max Lama
    // Purpose: Question 4
    // Restrictions: None
    internal class Program
    {
        static System.Timers.Timer timeOutTimer;
        static bool bTimeOut = false;

        static int nQuestion;

        // Method: Main
        // Purpose: Ask 3 questions and timeout when 5 seconds elapse
        // Restrictions: None
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("");
            nQuestion = 0;
            
            while(true)
            {
                Console.Write("Chose your question (1-3): ");
                try
                {
                    nQuestion = int.Parse(Console.ReadLine());
                    if (nQuestion >= 1 && nQuestion <= 3)
                    break;
                }
                catch
                {

                }
            }

            AskQuestion();

            timeOutTimer = new System.Timers.Timer(5000);
            timeOutTimer.Elapsed += new System.Timers.ElapsedEventHandler(TimesUp);
            timeOutTimer.Start();
            bTimeOut = false;

            string userInput = Console.ReadLine();
            timeOutTimer.Stop();

            if(!bTimeOut) PrintAnswers(true, userInput);

            while(true)
            {
                Console.Write("Play again? ");
                string yesOrNo = Console.ReadLine().ToLower();
                if (yesOrNo.Length != 0)
                {
                    if (yesOrNo[0] == 'y') goto start;
                    if (yesOrNo[0] == 'n') break;
                }
            }
        }

        // Method: AskQuestion
        // Purpose: Ask one of three qustions
        // Restrictions: None
        static void AskQuestion()
        {
            Console.WriteLine("You have 5 Seconds to answer the following question:");
            switch(nQuestion)
            {
                default: break;
                case 1:
                    Console.WriteLine("What is your favorite color?");
                    break;
                case 2:
                    Console.WriteLine("What is the answer to life, the universe and everything?");
                    break;
                case 3:
                    Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
                    break;
            }
        }

        // Method: PrintAnswers
        // Purpose: check answers, and print if wrong
        // Restrictions: None
        // @param {bool} check - whether or not to check the input string
        // @param {string} input = "" - input to check against the answers.
        static void PrintAnswers(bool check, string input = "")
        {
            string[] answers = new string[3] {"black", "42", "What do you mean? African or European swallow?"};
            bool wrong = false;

            // Check answers
            if(check)
            {
                if (input == answers[nQuestion - 1])
                {
                    Console.WriteLine("Well Done!");
                    return;
                }
                wrong = true;
            }
            // Print answers
            if (!check || wrong) 
            {
                if (!bTimeOut) Console.Write("Wrong!  ");
                Console.WriteLine($"The answer is: {answers[nQuestion - 1]}");
                if (bTimeOut) Console.WriteLine("Please press enter.");
            }
        }

        // Method: TimesUp
        // Purpose: stop timer and notify player
        // Restrictions: None
        static void TimesUp( object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Time's up!");
            bTimeOut = true;
            timeOutTimer.Stop();
            PrintAnswers(false);
        }
    }
}