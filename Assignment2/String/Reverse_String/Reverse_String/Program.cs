using System;

namespace Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();

            // Way 1: Convert to char array, reverse it, then convert back to string
            char[] characters = text.ToCharArray();

            Array.Reverse(characters);

            string reversedString = new string(characters);

            Console.WriteLine("Way 1: " + reversedString);

            // Way 2: Print the string from the last character to the first
            Console.Write("Way 2: ");

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }

            Console.WriteLine();
        }
    }
}