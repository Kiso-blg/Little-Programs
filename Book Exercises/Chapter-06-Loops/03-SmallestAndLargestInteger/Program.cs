using System;

namespace _03_SmallestAndLargestInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-6-loops/#_Toc362296424");
            Console.WriteLine("Exercise 3" + Environment.NewLine);

            Console.WriteLine("This program reads series of a given N count integers and prints the smallest and largest of them.");
            int min = int.MaxValue;
            int max = int.MinValue;
            int count = GetInteger();

            for (int i = 0; i < count; i++)
            {
                int number = GetInteger();
                min = Math.Min(min, number);
                max = Math.Max(max, number);
            }

            if (count > 0)
            {
                Console.WriteLine($"Smallest number: {min}");
                Console.WriteLine($"Largest number: {max}");
            }
            else
            {
                Console.WriteLine("No numbers entered.");
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