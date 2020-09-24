using System;

namespace _04_FormatNumbersInOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-4-console-input-and-output/#_Toc362296407");
            Console.WriteLine("Exercise 4" + Environment.NewLine);

            Console.WriteLine("This program reads three numbers and prints them in specific format.");
            Console.Write("Enter an integer: ");
            int integer = GetNumber();
            Console.Write("Enter fractional positive number: ");
            double positive = GetFractionalNumber("plus");
            Console.Write("Enter fractional negative number: ");
            double negative = GetFractionalNumber("minus");

            Console.Write($"|0x{integer,-8:X}|");
            Console.Write($"{positive,-10:F2}");
            Console.WriteLine($"|{negative,-10:F2}|");
        }

        private static double GetFractionalNumber(string sign)
        {
            string input = Console.ReadLine();

            if (!double.TryParse(input, out double num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetFractionalNumber(sign);
            }

            if (sign == "plus")
            {
                num = Math.Abs(num);
            }
            else
            {
                num = num < 0 ? num : num * -1;
            }

            return num;
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