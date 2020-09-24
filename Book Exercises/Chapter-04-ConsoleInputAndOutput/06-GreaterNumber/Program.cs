using System;

namespace _06_GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-4-console-input-and-output/#_Toc362296407");
            Console.WriteLine("Exercise 6" + Environment.NewLine);

            Console.WriteLine("This program prints the greater of two given numbers.");
            Console.Write("Enter the first number: ");
            double a = GetNumber();
            Console.Write("Enter the second number: ");
            double b = GetNumber();
            Console.WriteLine($"The greater number is {Math.Max(a, b)}");
        }

        private static double GetNumber()
        {
            string input = Console.ReadLine();

            if (!double.TryParse(input, out double num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetNumber();
            }

            return num;
        }
    }
}