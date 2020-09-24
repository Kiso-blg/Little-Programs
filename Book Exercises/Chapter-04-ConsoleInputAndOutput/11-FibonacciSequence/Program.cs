using System;
using System.Numerics;

namespace _11_FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-4-console-input-and-output/#_Toc362296407");
            Console.WriteLine("Exercise 11" + Environment.NewLine);

            Console.WriteLine("This program prints first 100 numbers from the Fibonacci sequence.");
            BigInteger a = 0;
            BigInteger n = 1;
            BigInteger m = 0;

            for (int i = 0; i < 100; i++)
            {
                // Starts with 0.
                Console.WriteLine($"{a,22}");
                a = m + n;
                n = m;
                m = a;
                // Starts with 1.
                // Console.WriteLine($"{a,23}");
            }
        }
    }
}