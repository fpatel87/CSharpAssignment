using System;

namespace Longest_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array: ");
            string[] input = Console.ReadLine().Split();

            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            int currentLength = 1;
            int longestLength = 1;
            int longestNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                }

                if (currentLength > longestLength)
                {
                    longestLength = currentLength;
                    longestNumber = numbers[i];
                }
            }

            for (int i = 0; i < longestLength; i++)
            {
                Console.Write(longestNumber + " ");
            }
        }
    }
}