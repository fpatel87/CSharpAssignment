using System;

namespace ArrayReverse2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] numbers = GenerateNumbers(length);
            Reverse(numbers);
            PrintNumbers(numbers);
        }

        // Creates an array of the desired length
        static int[] GenerateNumbers(int length)
        {
            int[] numbers = new int[length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
            return numbers;
        }

        // Reverses the array
        static void Reverse(int[] numbers)
        {
            for (int index = 0; index < numbers.Length / 2; index++)
            {
                int temp = numbers[index];
                numbers[index] = numbers[numbers.Length - index - 1];
                numbers[numbers.Length - index - 1] = temp;
            }
        }

        // Prints each number in the array
        static void PrintNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}