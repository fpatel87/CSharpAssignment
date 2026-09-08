using System;
using System.Collections.Generic;

namespace Reverse_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            char[] separators =
            {
                '.', ',', ':', ';', '=', '(', ')', '&',
                '[', ']', '"', '\'', '\\', '/', '!', '?', ' '
            };

            string[] words = sentence.Split(
                separators,
                StringSplitOptions.RemoveEmptyEntries
            );

            List<string> wordList = new List<string>(words);
            
            wordList.Reverse();
            
            int wordIndex = 0;
            string result = "";

            for (int i = 0; i < sentence.Length; i++)
            {
                if (Array.IndexOf(separators, sentence[i]) >= 0)
                {
                    result += sentence[i];
                }
                else
                {  
                    while (i < sentence.Length &&
                           Array.IndexOf(separators, sentence[i]) < 0)
                    {
                        i++;
                    }

                    i--;

                    result += wordList[wordIndex];
                    wordIndex++;
                }
            }

            Console.WriteLine(result);
        }
    }
}