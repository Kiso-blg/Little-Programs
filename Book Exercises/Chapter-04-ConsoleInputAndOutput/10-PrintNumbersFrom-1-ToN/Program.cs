using System;

namespace _10_PrintNumbersFrom_1_ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-4-console-input-and-output/#_Toc362296407");
            Console.WriteLine("Exercise 10" + Environment.NewLine);

            Console.WriteLine("This program reads given integer and prints all numbers from 1 to N.");
            Console.Write("Enter an integer N = ");
            int n = GetInteger();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
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