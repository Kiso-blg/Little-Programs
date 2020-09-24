using System;

namespace _14_IsANumberPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-3-operators-and-expressions/#_Toc362296398");
            Console.WriteLine("Exercise 14" + Environment.NewLine);

            Console.WriteLine("This program checks if a given number is prime.");
            Console.Write("Enter a number (N > -1): ");
            uint number = GetNumber();
            bool isPrime = IsPrime(number);
            Console.WriteLine(isPrime ? $"Yes, {number} is prime." : $"No, {number} is not prime.");
        }

        private static bool IsPrime(uint number)
        {
            if (number <= 1)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            uint boundary = (uint)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static uint GetNumber()
        {
            string input = Console.ReadLine();

            if (!uint.TryParse(input, out uint num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetNumber();
            }

            return num;
        }
    }
}