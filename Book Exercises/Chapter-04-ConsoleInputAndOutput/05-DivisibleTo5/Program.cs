using System;

namespace _05_DivisibleTo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-4-console-input-and-output/#_Toc362296407");
            Console.WriteLine("Exercise 5" + Environment.NewLine);

            Console.WriteLine("This program finds the count of integers with division by 5 == 0 by two given integers.");
            Console.Write("Enter first integer: ");
            int a = GetInteger();
            Console.Write("Enter second integer: ");
            int b = GetInteger();
            int count = Math.Abs((a / 5) - (b / 5));

            if (Math.Min(a, b) % 5 == 0)
            {
                count += 1;
            }

            Console.WriteLine($"There are {count} numbers where N % 5 == 0.");
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