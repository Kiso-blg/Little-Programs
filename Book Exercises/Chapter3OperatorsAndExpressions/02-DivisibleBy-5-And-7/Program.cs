using System;

namespace _02_DivisibleBy_5_And_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-3-operators-and-expressions/#_Toc362296398");
            Console.WriteLine("Exercise 2" + Environment.NewLine);

            Console.Write("Enter an integer: ");
            int num = GetInteger();
            bool isDivisible = num % 5 == 0 && num % 7 == 0;
            Console.WriteLine(isDivisible ? $"{num} is divisible by 5 and 7." : $"{num} is not divisible by 5 and 7.");
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