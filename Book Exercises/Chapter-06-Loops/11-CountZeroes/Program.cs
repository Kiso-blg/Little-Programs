using System;
using System.Numerics;

namespace _11_CountZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-6-loops/#_Toc362296424");
            Console.WriteLine("Exercise 11" + Environment.NewLine);

            Console.WriteLine("This program calculates the zeores in the end of the factorial of a given number.");
            Console.Write("Enter number N = ");
            int n = GetInteger();
            BigInteger factorial = GetFactorial(n);
            int zeroCount = CountZeroes(factorial);
            Console.WriteLine($"{factorial} contains {zeroCount} zeroes.");
        }

        private static int CountZeroes(BigInteger factorial)
        {
            int count = 0;

            while (factorial % 10 == 0)
            {
                count++;
                factorial /= 10;
            }

            return count;
        }

        private static BigInteger GetFactorial(int end)
        {
            BigInteger fact = 1;

            for (uint i = 1; i <= end; i++)
            {
                fact *= i;
            }

            return fact;
        }

        private static int GetInteger()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetInteger();
            }

            return Math.Abs(num);
        }
    }
}