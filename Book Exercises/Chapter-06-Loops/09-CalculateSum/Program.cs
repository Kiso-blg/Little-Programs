using System;

namespace _09_CalculateSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-6-loops/#_Toc362296424");
            Console.WriteLine("Exercise 9" + Environment.NewLine);

            Console.WriteLine("This program calculates the sum S = 1 + (1!)/x + 2!/x^2 + n!/x^n by given N and X.");
            Console.WriteLine("Enter number N = ");
            int n = GetInteger();
            Console.WriteLine("Enter number X = ");
            int x = GetInteger();
            decimal pow = x;
            decimal result = 1;
            decimal fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                //Console.WriteLine($"{fact} / {pow}");
                result += fact / pow;
                pow *= x;
            }

            Console.WriteLine($"Result: {result}");
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