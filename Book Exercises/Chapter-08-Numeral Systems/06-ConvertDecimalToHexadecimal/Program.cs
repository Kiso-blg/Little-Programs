using System;

namespace _06_ConvertDecimalToHexadecimal
{
    class Program
    {
        static readonly string hexNumbers = "0123456789ABCDEF";

        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-8-numeral-systems/#_Toc362296443");
            Console.WriteLine("Exercise 6" + Environment.NewLine);

            Console.WriteLine("This program converts a given decimal number to hexadecimal one.");
            Console.Write("Enter a number: ");
            long n = GetNumber();
            string hexNumber = ConvertToHex(n);
            Console.WriteLine($"The number {n} is 0x{hexNumber} in hexadecimal numeral system.");
        }

        private static string ConvertToHex(long n)
        {
            string hex = string.Empty;

            while (n > 0)
            {
                hex = hexNumbers[(int)(n % 16)] + hex;
                n /= 16;
            }

            return hex;
        }

        private static long GetNumber()
        {
            string input = Console.ReadLine();

            if (!long.TryParse(input, out long num))
            {
                Console.WriteLine("Invalid input. Enter the number again");
                num = GetNumber();
            }

            return Math.Abs(num);
        }
    }
}