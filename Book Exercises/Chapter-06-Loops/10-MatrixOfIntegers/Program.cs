using System;

namespace _10_MatrixOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-6-loops/#_Toc362296424");
            Console.WriteLine("Exercise 10" + Environment.NewLine);

            Console.WriteLine("This program prints a matrix of integers by a given size N < 20.");
            Console.Write("Enter a size: N = ");
            uint n = GetInteger();

            for (int row = 0; row < n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    Console.Write($"{row + col, 2} ");
                }

                Console.WriteLine();
            }

        }

        private static uint GetInteger()
        {
            string input = Console.ReadLine();

            if (!uint.TryParse(input, out uint num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetInteger();
            }

            if (num > 19)
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetInteger();
            }

            return num;
        }
    }
}