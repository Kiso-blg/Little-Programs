using System;

namespace _02_ConvertToDecimalAndHexadecimal
{
    class Program
    {
        static readonly string hexNumbers = "0123456789ABCDEF";

        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-8-numeral-systems/#_Toc362296443");
            Console.WriteLine("Exercise 2" + Environment.NewLine);

            Console.WriteLine("This program converts the binary number 1111010110011110(2) to decimal and hexadecimal numeral systems.");
            string binary = "1111010110011110";
            int pow = binary.Length - 1;
            double num = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                int multiplier = (int)char.GetNumericValue(binary[i]);
                num += multiplier * (Math.Pow(2, pow));
                pow--;
            }

            Console.WriteLine(num);            
            string hex = string.Empty;
            int n = (int)num;

            while (n > 0)
            {
                hex = hexNumbers[n % 16] + hex;
                n /= 16;
            }

            Console.WriteLine($"{binary} is {num} in decimal and 0x{hex} in hexadecimal numeral systems.");
        }
    }
}