using System;
using System.Numerics;

namespace _05_FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-6-loops/#_Toc362296424");
            Console.WriteLine("Exercise 5" + Environment.NewLine);

            Console.WriteLine("This program prints the sum of the first N members of the Fibonacci seqeunce by a given N.");
            Console.Write("Enter the count of the members N = ");
            int count = GetInteger();
            BigInteger sum = 0;

            BigInteger a = 0;
            BigInteger n = 1;
            BigInteger m = 0;

            for (int i = 0; i < count; i++)
            {
                //Console.WriteLine($"{a,22}");
                a = m + n;
                n = m;
                m = a;
                sum += a;
            }

            Console.WriteLine($"Sum: {sum}");
        }

        private static int GetInteger()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetInteger();
            }

            return num;
        }
    }
}