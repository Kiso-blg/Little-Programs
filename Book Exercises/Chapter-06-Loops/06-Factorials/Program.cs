using System;

namespace _06_Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-6-loops/#_Toc362296424");
            Console.WriteLine("Exercise 6" + Environment.NewLine);

            Console.WriteLine("This program calculates N!/K! for given N and K (1 < K < N).");
            Console.Write("Enter number 1 < K: K = ");
            uint k = GetInteger(1u);
            Console.Write("Enter number K < N: N = ");
            uint n = GetInteger(k);
            
            decimal result = GetResult(n, k);
            Console.WriteLine(result);
        }

        private static uint GetInteger(uint min)
        {
            string input = Console.ReadLine();

            if (!uint.TryParse(input, out uint num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetInteger(min);
            }

            if (num <= min)
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetInteger(min);
            }

            return num;
        }

        private static decimal GetResult(uint n, uint k)
        {
            decimal sum = 1;

            for (uint i = k + 1; i <= n; i++)
            {
                sum *= i;
            }

            return sum;
        }
    }
}