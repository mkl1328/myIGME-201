using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace PE07
{
    // Author: Max Lama
    // Purpose: Handle the input and output for a mad lib game
    // Restrictions: None
    internal class Program
    {
        // Purpose: Run the mad lib game
        // Restrictions: None
        static void Main(string[] args)
        {
            StreamReader input = null;
            string resultString = "";
            //List<string> words = new List<string>();

            if (!Ask("Do you want to play Mad Libs?"))
            {
                Environment.Exit(1);
            }

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
                    int numOfStories = HowManyStories(input);
                    input.Close();

                    input = new StreamReader("..\\..\\txt\\MadLibsTemplate.txt");
                    string[] words = SelectStory(input, numOfStories).Split(' ');

                    resultString = PlayGame(words);
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

                if (!Ask("Do you want to play again?"))
                {
                    break;
                }
            }
            Console.WriteLine(" Thanks for playing!");
        }

        // Purpose: Ask a yes or no question and handle data validation
        // Restrictions: Has hard-coded 3-time and 10-time error messages.
        // @param: <string> question -  what question to ask;
        // @return: <bool> - answer to the question.
        static bool Ask(string question)
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
                        Console.WriteLine("Okay, Goodbye.");
                        keepLooping = false;
                        break;
                }
            }
            return false;
        }

        // Purpose: To figure out how many stories are in the document
        // Restrictions: Stories must be split up by line in the txt document
        // @param: <StreamReader> - the strem to read from. 
        // @return: <int> - how many stories are in the document (lines)
        static int HowManyStories(StreamReader input)
        {
            int count = 0;
            string line = null;
            while ((line = input.ReadLine()) != null)
            {
                count++;
            };
            return count;
        }

        // Purpose: Select a story based on the user's input
        // Restrictions: None
        // @param: <StreamReader> input - stream to read from
        // @param: <int> numOfStories - How many stories there are in the doc
        // @return: <string> - The selected story in string value
        static string SelectStory(StreamReader input, int numOfStories)
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
        
        // Purpose: Loop through the story's word array to create the madlib.
        // Restriction: If the story has any escape characters besides \n, they will be ignored, and replaced with a line break.
        // @param: <string[]> words - Word array of words in the story.
        // @return: <string> - Concatenated story.
        static string PlayGame(string[] words)
        {
            string result = "";

            foreach(string word in words)
            {
                switch (word[0])
                {
                    default: result += $"{word} "; break;
                    case '\\' : result += "\n"; break;                      // Would have to change this case to accomodate other escape characters.
                    case '{' : result += $"{PromptUser(word)} "; break;
                }
            }

            return result;
        }

        // Purpose: Prompt and Get user input for the mad lib word
        // Restrictions: If there are other punctuation marks not accounted for like ":", "$", ";", ")" etc, the formating breaks.
        //               The use still works, it just looks messy when prompting.
        // @param: <string> prompt - Word in {} in the story
        // @return: <string> - User's input.
        static string PromptUser(string prompt)
        {
            char punctuation = prompt[prompt.Length - 1];           //Punctuation marks aren't separated from prompt words since 
                                                                    // there is no space between them and the prompt closing bracket.
            char[] charsToTrim = {'?', '!', '.', ',', '{', '}'};
            prompt = prompt.Replace('_', ' ');
            prompt = prompt.Trim(charsToTrim);

            string response;
            while (true)
            {
                Console.Write($"Please enter a {prompt}: ");
                response = Console.ReadLine().Trim();
                if (response == "")
                {
                    Console.WriteLine("Give me a real Answer!");
                }
                else
                {
                    break;
                }
            }

            if (punctuation != '}')
            {
                response += punctuation;
            }
            return response;

        }
    }
}
