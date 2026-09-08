using System;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear):");

                string input = Console.ReadLine();

                if (input == "--")
                {
                    items.Clear();
                }
                else if (input.StartsWith("+"))
                {
                    string item = input.Substring(1).Trim();
                    items.Add(item);
                }
                else if (input.StartsWith("-"))
                {
                    string item = input.Substring(1).Trim();
                    items.Remove(item);
                }

                Console.WriteLine("Current list:");

                foreach (string item in items)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();
            }
        }
    }
}

