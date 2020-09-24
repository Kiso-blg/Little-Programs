using System;

namespace _02_NumbersFromOneToN_Vol_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-6-loops/#_Toc362296424");
            Console.WriteLine("Exercise 2" + Environment.NewLine);

            Console.WriteLine("This program prints the numbers from 1 to N which are not divisible by 3 and 7 by given N number.");
            Console.Write("Enter a number: N = ");
            int n = GetInteger();
            int cursorLeft = 0;
            int columnsCount = 0;

            for (int i = 1; i <= n; i++)
            {
                if (!(i % 3 == 0 && i % 7 == 0))
                {
                    Console.Write($"{i}, ");
                    columnsCount++;

                    if (columnsCount % 20 == 0)
                    {
                        cursorLeft = Console.CursorLeft - 2;
                        Console.SetCursorPosition(0, Console.CursorTop + 1);
                    }
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