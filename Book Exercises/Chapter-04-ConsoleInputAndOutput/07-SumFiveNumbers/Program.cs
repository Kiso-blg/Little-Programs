using System;

namespace _07_SumFiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-4-console-input-and-output/#_Toc362296407");
            Console.WriteLine("Exercise 7" + Environment.NewLine);

            Console.WriteLine("This program reads 5 integers from the console (A, B, C, D, E) and print their sum.");
            Console.Write("Enter number A = ");
            int a = GetNumber();
            Console.Write("Enter number B = ");
            int b = GetNumber();
            Console.Write("Enter number C = ");
            int c = GetNumber();
            Console.Write("Enter number D = ");
            int d = GetNumber();
            Console.Write("Enter number E = ");
            int e = GetNumber();
            long sum = (long)a + b + c + d + e;
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