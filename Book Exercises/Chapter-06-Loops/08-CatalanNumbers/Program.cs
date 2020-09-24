using System;
using System.Numerics;

namespace _08_CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-6-loops/#_Toc362296424");
            Console.WriteLine("Exercise 8" + Environment.NewLine);

            Console.WriteLine("This program calculates the Nth Catalan number by a given N.");
            Console.Write("Enter a number: N = ");
            uint n = GetInteger();
            BigInteger factN1 = CalcFactorial(1u, n);
            BigInteger factN2 = CalcFactorial(n + 2, n * 2);
            BigInteger catalan = (factN2 / factN1);
            Console.WriteLine($"The Catalan's number is {catalan}");
        }

        private static BigInteger CalcFactorial(uint start, uint end)
        {
            BigInteger fact = 1;

            for (uint i = start; i <= end; i++)
            {
                fact *= i;
            }

            return fact;
        }
        private static uint GetInteger()
        {
            string input = Console.ReadLine();

            if (!uint.TryParse(input, out uint num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetInteger();
            }

            return num;
        }
    }
}