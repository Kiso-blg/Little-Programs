using System;

namespace _04_DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-2-primitive-types-and-variables/#_Toc362296391");
            Console.WriteLine("Exercise 4" + Environment.NewLine);

            int dec = 256;
            string hex = dec.ToString("X");
            Console.WriteLine($"{dec} is 0x{hex} in hexadecimal.");

            Console.WriteLine("Enter an integer. (N > 0)");
            uint num = GetNumber();
            string toHex = num.ToString("X");
            Console.WriteLine($"{num} is 0x{toHex} in hexadecimal.");
        }

        private static uint GetNumber()
        {
            string input = Console.ReadLine();

            if (!uint.TryParse(input, out uint num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetNumber();
            }

            return num;
        }
    }
}