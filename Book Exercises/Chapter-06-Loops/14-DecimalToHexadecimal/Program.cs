using System;

namespace _14_DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-6-loops/#_Toc362296424");
            Console.WriteLine("Exercise 14" + Environment.NewLine);

            Console.WriteLine("This program converts a given decimal number to hexadecimal.");
            Console.Write("Enter number ");
            ulong n = GetInteger();
            ulong num = n;
            string alphabet = "0123456789ABCDEF";
            string hex = string.Empty;

            while (num > 0)
            {
                hex = alphabet[(int)(num % 16)] + hex;
                num /= 16;
            }

            Console.WriteLine($"{n} is in hexadecimal 0x{hex}");
        }

        private static ulong GetInteger()
        {
            string input = Console.ReadLine();

            if (!ulong.TryParse(input, out ulong num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetInteger();
            }

            return num;
        }
    }
}