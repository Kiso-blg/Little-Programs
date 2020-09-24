using System;

namespace _09_SumOf_N_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-4-console-input-and-output/#_Toc362296407");
            Console.WriteLine("Exercise 9" + Environment.NewLine);

            Console.WriteLine("This program reads N integers and print their sum.");
            Console.Write("Enter integer's Count = ");
            int count = GetNumber();
            long sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += GetNumber();
            }

            Console.WriteLine($"Sum = {sum}");
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