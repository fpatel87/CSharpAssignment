using System;

namespace Rotated_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n and k: ");
            string[] firstInput = Console.ReadLine().Split();

            int n = int.Parse(firstInput[0]);
            int k = int.Parse(firstInput[1]);

            Console.Write("Enter the array: ");
            string[] input = Console.ReadLine().Split();

            int[] numbers = new int[n];
            int[] sum = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            // Rotate k times
            for (int r = 1; r <= k; r++)
            {
                int[] rotated = new int[n];

                // Rotate the array
                for (int i = 0; i < n; i++)
                {
                    int newPosition = (i + r) % n;
                    rotated[newPosition] = numbers[i];
                }

                // Show rotated array
                Console.Write("rotated" + r + "[] = ");

                for (int i = 0; i < n; i++)
                {
                    Console.Write(rotated[i] + " ");
                }

                Console.WriteLine();

                // Add rotated array to sum
                for (int i = 0; i < n; i++)
                {
                    sum[i] += rotated[i];
                }
            }

            // Show sum array
            Console.Write("sum[] = ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(sum[i] + " ");
            }
        }
    }
}