using System;
using System.Collections.Generic;

namespace MostFrequentNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the numbers: ");
            string[] input = Console.ReadLine().Split();

            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            int maxFrequency = 0;

            // Find the maximum frequency
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentFrequency = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentFrequency++;
                    }
                }

                if (currentFrequency > maxFrequency)
                {
                    maxFrequency = currentFrequency;
                }
            }

            // Find all numbers with maximum frequency
            List<int> mostFrequentNumbers = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentFrequency = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentFrequency++;
                    }
                }

                if (currentFrequency == maxFrequency &&
                    !mostFrequentNumbers.Contains(numbers[i]))
                {
                    mostFrequentNumbers.Add(numbers[i]);
                }
            }

            // Only one number has the maximum frequency
            if (mostFrequentNumbers.Count == 1)
            {
                Console.WriteLine(
                    $"The number {mostFrequentNumbers[0]} is the most frequent " +
                    $"(occurs {maxFrequency} times)"
                );
            }
            else
            {
                // Multiple numbers have the same maximum frequency
                Console.Write("The numbers ");

                for (int i = 0; i < mostFrequentNumbers.Count; i++)
                {
                    if (i > 0 && i == mostFrequentNumbers.Count - 1)
                    {
                        Console.Write(" and ");
                    }
                    else if (i > 0)
                    {
                        Console.Write(", ");
                    }

                    Console.Write(mostFrequentNumbers[i]);
                }

                Console.WriteLine(
                    $" have the same maximal frequence (each occurs {maxFrequency} times). " +
                    $"The leftmost of them is {mostFrequentNumbers[0]}."
                );
            }
        }
    }
}