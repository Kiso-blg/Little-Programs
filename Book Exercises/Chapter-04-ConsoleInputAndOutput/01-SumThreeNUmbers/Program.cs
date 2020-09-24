using System;

namespace _01_SumThreeNUmbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-4-console-input-and-output/#_Toc362296407");
            Console.WriteLine("Exercise 1" + Environment.NewLine);

            Console.WriteLine("This program reads 3 integers from the console (A, B, C) and print their sum.");
            Console.Write("Enter number A = ");
            int a = GetNumber();
            Console.Write("Enter number B = ");
            int b = GetNumber();
            Console.Write("Enter number C = ");
            int c = GetNumber();
            long sum = (long)a + b + c;
            Console.WriteLine($"{a} + {b} + {c} = {sum}");
        }

        private static int GetNumber()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetNumber();
            }

            return num;
        }
    }
}