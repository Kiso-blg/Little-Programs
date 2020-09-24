using System;
using System.Numerics;

namespace _10_N_FactorialFrom_1_To_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-9-methods/#_Toc362296457");
            Console.WriteLine("Exercise 10" + Environment.NewLine);

            Console.WriteLine("This program prints N! in range 1-100 by a given number N.");
            Console.Write("Enter number in rane 1-100 N = ");
            int n = GetNumber();
            PrintFactorial(n);
        }

        private static void PrintFactorial(int n)
        {
            BigInteger fact = 1;

            for (int i = 1; i < n + 1; i++)
            {
                fact *= i;
                Console.WriteLine($"Factorial {i} is {fact}");
            }
        }

        private static int GetNumber()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Invalid input. Enter the number again.");
                num = GetNumber();
            }

            if (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid input. Enter the number again.");
                num = GetNumber();
            }

            return Math.Abs(num);
        }
    }
}