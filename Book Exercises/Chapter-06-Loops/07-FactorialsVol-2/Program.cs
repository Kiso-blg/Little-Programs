using System;

namespace _07_FactorialsVol_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-6-loops/#_Toc362296424");
            Console.WriteLine("Exercise 7" + Environment.NewLine);

            Console.WriteLine("This program calculates N!*K!/(N-K)! for given N and K (1 < K < N).");
            Console.Write("Enter number 1 < K: K = ");
            uint k = GetInteger(1u);
            Console.Write("Enter number K < N: N = ");
            uint n = GetInteger(k);
            uint diff = n - k;
            decimal kFactorial = 0;
            decimal diffFactorial = 0;
            decimal nFactorial = GetResult(n, k, diff, ref kFactorial, ref diffFactorial);
            decimal result = nFactorial * kFactorial / diffFactorial;
            Console.WriteLine($"N!*K!/(N-K)! = {result}");
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

        private static decimal GetResult(uint n, uint k, uint diff, ref decimal kFactorial, ref decimal diffFactorial)
        {
            decimal sum = 1;

            for (uint i = 1; i <= n; i++)
            {
                sum *= i;

                if (i == k)
                {
                    kFactorial = sum;
                }

                if (i == diff)
                {
                    diffFactorial = sum;
                }
            }

            return sum;
        }
    }
}