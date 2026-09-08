using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    internal class Program
    {
        static int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();

            for (int number = startNum; number <= endNum; number++)
            {
                bool isPrime = true;

                if (number < 2)
                {
                    isPrime = false;
                }
                else
                {
                    for (int divisor = 2; divisor < number; divisor++)
                    {
                        if (number % divisor == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    primes.Add(number);
                }
            }

            return primes.ToArray();
        }

        static void Main(string[] args)
        {
            Console.Write("Enter start number: ");
            int startNum = int.Parse(Console.ReadLine());

            Console.Write("Enter end number: ");
            int endNum = int.Parse(Console.ReadLine());

            int[] result = FindPrimesInRange(startNum, endNum);

            Console.WriteLine("Prime numbers:");

            foreach (int prime in result)
            {
                Console.Write(prime + " ");
            }
        }
    }
}

