using System;

namespace _01_Convert_Decimal_Numbers_To_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-8-numeral-systems/#_Toc362296443");
            Console.WriteLine("Exercise 1" + Environment.NewLine);

            Console.WriteLine("This program converts the numbers 151, 35, 43, 251, 1023 and 1024 to binary numeral system.");
            ConverIntegerToBinary(151);
            ConverIntegerToBinary(35);
            ConverIntegerToBinary(43);
            ConverIntegerToBinary(251);
            ConverIntegerToBinary(1023);
            ConverIntegerToBinary(1024);
        }

        private static void ConverIntegerToBinary(int num)
        {
            string binary = string.Empty;
            int n = num;

            while (n > 0)
            {
                binary += n % 2;
                n /= 2;
            }

            char[] binaryToChar = binary.ToCharArray();
            Array.Reverse(binaryToChar);
            Console.WriteLine($"The number {num} is {string.Join("", binaryToChar)} in binary.");
        }
    }
}