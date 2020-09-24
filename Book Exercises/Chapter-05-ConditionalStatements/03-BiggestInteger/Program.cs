using System;

namespace _03_BiggestInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-5-conditional-statements/#_Toc362296414");
            Console.WriteLine("Exercise 3" + Environment.NewLine);

            Console.WriteLine("This program prints the biggest of three given integers using nested If statements.");
            Console.Write("Enter the first integer: ");
            int a = GetInteger();
            Console.Write("Enter the second integer: ");
            int b = GetInteger();
            Console.Write("Enter the third integer: ");
            int c = GetInteger();
            Console.Write("The greatest number is ");

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
            else if (b > a)
            {
                if (b > c)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(c);
                }
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
