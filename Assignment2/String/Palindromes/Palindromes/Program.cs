using System;
using System.Collections.Generic;

namespace Palindromes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            char[] separators =
            {
                ' ', ',', '.', ':', ';', '=', '(', ')',
                '&', '[', ']', '"', '\'', '\\', '/', '!', '?'
            };

                string[] words = text.Split(
                separators,
                StringSplitOptions.RemoveEmptyEntries
            );

            List<string> palindromes = new List<string>();

            foreach (string word in words)
            {
                string reversed = "";

                
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversed += word[i];
                }

                if (word.Equals(reversed, StringComparison.OrdinalIgnoreCase))
                {
                    
                    if (!palindromes.Contains(word, StringComparer.OrdinalIgnoreCase))
                    {
                        palindromes.Add(word);
                    }
                }
            }

            palindromes.Sort(StringComparer.OrdinalIgnoreCase);

            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}