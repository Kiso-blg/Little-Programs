using System;

namespace _15_HexadecimalToDecimal
{
    class Program
    {
        static char[] hexes = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-6-loops/#_Toc362296424");
            Console.WriteLine("Exercise 15" + Environment.NewLine);

            Console.WriteLine("This program converts a given Hexadecimal number to Decimal.");
            Console.Write("Enter a hexadecimal number: ");
            string hex = GetHexNumber();
            ulong number = 0;
            ulong pow = 1;

            for (int i = hex.Length - 1; i >= 0; i--)
            {
                number += (ulong)Array.IndexOf(hexes, hex[i]) * pow;
                pow *= 16;
            }

            Console.WriteLine($"The hexadecimal number {hex} in decimal is {number}");
        }

        private static string GetHexNumber()
        {
            string input = Console.ReadLine().ToUpper();
            bool notHex = false;

            for (int i = 0; i < input.Length; i++)
            {
                bool isDigit = input[i] > 47 && input[i] < 58;
                bool isAlpha = input[i] > 64 && input[i] < 71;

                if (isDigit ^ isAlpha)
                {
                    notHex = false;
                }
                else
                {
                    notHex = true;
                    break;
                }
            }

            if (notHex)
            {
                Console.WriteLine("Incorrect input. Try again.");
                input = GetHexNumber();
            }

            if (input == string.Empty)
            {
                Console.WriteLine("Incorrect input. Try again.");
                input = GetHexNumber();
            }

            return input;
        }
    }
}