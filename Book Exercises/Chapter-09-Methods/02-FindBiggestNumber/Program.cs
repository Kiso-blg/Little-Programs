using System;

namespace _02_FindBiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-9-methods/#_Toc362296457");
            Console.WriteLine("Exercise 2" + Environment.NewLine);

            Console.WriteLine("This program reads three numbers of type int and return the biggest of them.");
            Console.Write("Enter the first number: ");
            int a = GetNumber();
            Console.Write("Enter the second number: ");
            int b = GetNumber();
            Console.Write("Enter the third number: ");
            int c = GetNumber();

            int biggestNumber = GetMax(a, GetMax(b, c));
            Console.WriteLine($"The biggest number is {biggestNumber}.");
        }

        private static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        private static int GetNumber()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Ivalid input. Enter the number again.");
                num = GetNumber();
            }

            return num;
        }
    }
}