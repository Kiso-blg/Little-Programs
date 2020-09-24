using System;

namespace _03_ConvertHexadecimalToDecimalAndBinary
{
    class Program
    {
        static char[] hexes = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-8-numeral-systems/#_Toc362296443");
            Console.WriteLine("Exercise 3" + Environment.NewLine);

            Console.WriteLine("This program converts the numbers 0xFA, 0x2A3E, 0xFFFF, 0x5A0E9 to decimal and binary numeral systems.");
            Console.WriteLine();
            ConvertToDecimalAndBinary("FA");
            ConvertToDecimalAndBinary("2A3E");
            ConvertToDecimalAndBinary("FFFF");
            ConvertToDecimalAndBinary("5A0E9");
        }

        private static void ConvertToDecimalAndBinary(string hex)
        {
            ulong decNumber = 0;
            ulong pow = 1;

            for (int i = hex.Length - 1; i > -1; i--)
            {
                decNumber += (ulong)Array.IndexOf(hexes, hex[i]) * pow;
                pow *= 16;
            }

            string binary = string.Empty;
            ulong n = decNumber;

            while (n > 0)
            {
                binary += n % 2;
                n /= 2;
            }

            char[] binaryToChar = binary.ToCharArray();
            Array.Reverse(binaryToChar);
            Console.WriteLine($"The number 0x{hex} is {decNumber} in decimal and {string.Join("", binaryToChar)} in binary numeral systems.");
            Console.WriteLine();
        }        
    }
}