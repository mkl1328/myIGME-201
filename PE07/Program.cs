using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace PE07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = null;
            string resultString = "";
            //List<string> words = new List<string>();

            if(!ask("Do you want to play Mad Libs?")) Environment.Exit(1);

            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine().Trim();
            if(userName == "")
            {
                Console.WriteLine("That's not a very good name. I'll call you Amanda.");
                userName = "Amanda";
            }

            while (true)
            {
                //Stream Reader
                try
                {
                    input = new StreamReader("..\\..\\txt\\MadLibsTemplate.txt");
                    int numOfStories = howManyStories(input);
                    input.Close();

                    input = new StreamReader("..\\..\\txt\\MadLibsTemplate.txt");
                    string[] words = selectStory(input, numOfStories).Split(' ');

                    resultString = playGame(words);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error with the file!" + e.Message);
                }
                finally
                {
                    if (input != null)
                    {
                        input.Close();
                    }
                }

                Console.WriteLine($"Good Job, {userName}! This is the story you made:");
                Console.WriteLine(resultString);

                if (!ask("Do you want to play again?")) break;
            }
            Console.Write(" Thanks for playing!");
        }

        //Start game thing. (step 9)
        static bool ask(string question)
        {
            bool keepLooping = true;
            int counter = 1;
            while (keepLooping)
            {
                Console.Write($"{question}   ");
                switch(Console.ReadLine().ToLower())
                {
                    default:
                        if (counter == 3)
                        {
                            Console.WriteLine("You're killing me, just say yes or no");
                        } else if (counter == 10) {
                            Console.WriteLine("This isn't worth my time");
                            Environment.Exit(1);
                        }
                        counter++;
                        break;
                    case "yes":
                        keepLooping = false;
                        return true;
                    case "no":
                        Console.WriteLine(":( Okay, Goodbye.");
                        keepLooping = false;
                        break;
                }
            }
            return false;
        }

        //Determines how many stories (lines) are in the text file
        static int howManyStories(StreamReader input)
        {
            int count = 0;
            string line = null;
            while ((line = input.ReadLine()) != null)
            {
                count++;
            };
            return count;
        }
        // Takes user input and determines the story to use.
        static string selectStory(StreamReader input, int numOfStories)
        {
            int pickedStory;
            while (true)
            {
                try
                {
                    Console.WriteLine($"Please enter the number of the story you'd like to play. (1-{numOfStories}");
                    pickedStory = Convert.ToInt32(Console.ReadLine());
                    if(pickedStory >= 1 && pickedStory <= numOfStories)
                    {
                        break;
                    }
                    Console.WriteLine("That's not a valid number, try again.");
                }
                catch
                {
                    Console.WriteLine("Please put in a number!");
                }
            }

            string story = "";
            for(int i = 0; i < pickedStory; i++)
            {
                story = input.ReadLine();
            }
            input.Close();
            return story;
        }
        
        //Loop for gameplay
        static string playGame(string[] words)
        {
            string result = "";

            foreach(string word in words)
            {
                switch (word[0])
                {
                    default: result += $"{word} "; break;
                    case '\\' : result += "\n"; break;
                    case '{' : result += $"{promptUser(word)} "; break;
                }
            }

            return result;
        }

        //Gives prompts and Acquires responses
        static string promptUser(string prompt)
        {
            bool hasComma = false;
            if (prompt.Contains(',')) hasComma = true;
            char[] charsToTrim = {',', '{', '}'};
            prompt = prompt.Replace('_', ' ');
            prompt = prompt.Trim(charsToTrim);

            string response;
            while (true)
            {
                Console.Write($"Please enter a {prompt}: ");
                response = Console.ReadLine().Trim();
                if (response == "") Console.WriteLine("Give me a real Answer!");
                else break;
            }
      
            if (hasComma) response += ",";
            return response;

        }
    }
}
