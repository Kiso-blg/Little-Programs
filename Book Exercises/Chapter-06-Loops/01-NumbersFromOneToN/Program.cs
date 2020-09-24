using System;

namespace _01_NumbersFromOneToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-6-loops/#_Toc362296424");
            Console.WriteLine("Exercise 1" + Environment.NewLine);

            Console.WriteLine("This program prints the numbers from 1 to N by given N number.");
            Console.Write("Enter a number: N = ");
            int n = GetInteger();
            int cursorLeft = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}, ");

                if (i % 20 == 0)
                {
                    cursorLeft = Console.CursorLeft - 2;
                    Console.CursorTop++;
                    Console.CursorLeft = 0;
                }
            }

            if (Console.CursorLeft == 0)
            {
                Console.SetCursorPosition(cursorLeft, Console.CursorTop - 1);
            }
            else
            {
                Console.CursorLeft -= 2;
            }

            Console.WriteLine(" ");
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