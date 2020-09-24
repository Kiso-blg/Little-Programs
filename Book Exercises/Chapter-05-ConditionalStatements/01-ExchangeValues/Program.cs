using System;

namespace _01_ExchangeValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-5-conditional-statements/#_Toc362296414");
            Console.WriteLine("Exercise 1" + Environment.NewLine);

            Console.WriteLine("This program reads two integers and exchange their values if the first one is greater.");
            Console.Write("Enter the first integer: ");
            int a = GetInteger();
            Console.Write("Enter the second integer: ");
            int b = GetInteger();

            if (a > b)
            {
                a ^= b;
                b ^= a;
                a ^= b;
            }

            Console.WriteLine($"A = {a}; B = {b}");
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