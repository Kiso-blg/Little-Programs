using System;

namespace _01_OddOrEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-3-operators-and-expressions/#_Toc362296398");
            Console.WriteLine("Exercise 1" + Environment.NewLine);

            Console.Write("Enter an integer: ");
            int num = GetInteger();

            if ((num & 1) == 0)
            {
                Console.WriteLine($"{num} is even.");
            }
            else
            {
                Console.WriteLine($"{num} is odd.");
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