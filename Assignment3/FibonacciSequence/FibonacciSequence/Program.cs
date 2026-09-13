using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Fibonacci number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci number: " + Fibonacci(number));

        }

        static int Fibonacci(int number)
        {
            // Base case
            if (number == 1 || number == 2)
            {
                return 1;
            }

            // Recursive case
            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}
