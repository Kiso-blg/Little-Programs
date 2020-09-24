using System;

namespace _15_ConvertFloatToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-8-numeral-systems/#_Toc362296443");
            Console.WriteLine("Exercise 15" + Environment.NewLine);

            Console.WriteLine("This program prints sign, exponent and mantissa in binary numeral system of a given float type number.");
            Console.Write("Enter a float type number: ");
            float floatNumber = GetFloatNumber();
            long inBinary = BitConverter.DoubleToInt64Bits(floatNumber);
            string result = string.Empty;

            for (int i = 63; i > -1; i--)
            {
                result += (inBinary >> i) & 1;
            }

            Console.WriteLine($"The number {floatNumber} in binary is: ");
            Console.WriteLine(result);
        }

        private static float GetFloatNumber()
        {
            string input = Console.ReadLine();

            if (!float.TryParse(input, out float f))
            {
                Console.WriteLine("Invalid input. Enter the float number again.");
                f = GetFloatNumber();
            }

            return f;
        }
    }
}