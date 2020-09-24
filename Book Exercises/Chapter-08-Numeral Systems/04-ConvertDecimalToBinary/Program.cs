using System;

namespace _04_ConvertDecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-8-numeral-systems/#_Toc362296443");
            Console.WriteLine("Exercise 4" + Environment.NewLine);

            Console.WriteLine("This program converts a given decimal number to binary one.");
            Console.Write("Enter a number: ");
            uint n = GetNumber();
            ConverIntegerToBinary(n);
        }

        private static void ConverIntegerToBinary(uint decNumber)
        {
            string binary = string.Empty;
            uint n = decNumber;

            while (n > 0)
            {
                binary += n % 2;
                n /= 2;
            }

            char[] binaryToChar = binary.ToCharArray();
            Array.Reverse(binaryToChar);
            Console.WriteLine($"The number {decNumber} is {string.Join("", binaryToChar)} in binary.");
        }

        private static uint GetNumber()
        {
            string input = Console.ReadLine();

            if (!uint.TryParse(input, out uint num))
            {
                Console.WriteLine("Invalid input. Enter the number again");
                num = GetNumber();
            }

            return num;
        }
    }
}