using System;

namespace _08_ConvertHexadecimalToBinary
{
    class Program
    {
        static readonly char[] hexNumbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-8-numeral-systems/#_Toc362296443");
            Console.WriteLine("Exercise 8" + Environment.NewLine);

            Console.WriteLine("This program converts a given hexadecimal number to binary one.");
            Console.Write("Enter a hexadecimal number: ");
            string hexNumber = GetHexNumber();
            string binary = ConvertToBinary(hexNumber);
            Console.WriteLine($"0x{hexNumber} is {binary} in binary numeral system.");
        }

        private static string ConvertToBinary(string hexNumber)
        {
            ulong decNumber = 0;
            ulong pow = 1;

            for (int i = hexNumber.Length - 1; i > -1; i--)
            {
                decNumber += (ulong)Array.IndexOf(hexNumbers, hexNumber[i]) * pow;
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
            return string.Join("", binaryToChar);
        }

        private static string GetHexNumber()
        {
            string input = Console.ReadLine().ToUpper();
            bool notHex = false;

            if (input == string.Empty)
            {
                Console.WriteLine("Invalid input. Enter the hexadecimal number again.");
                input = GetHexNumber();
            }

            for (int i = 0; i < input.Length; i++)
            {
                bool isDigit = input[i] > 47 && input[i] < 58;
                bool isLetter = input[i] > 64 && input[i] < 71;

                if (!(isDigit ^ isLetter))
                {
                    notHex = true;
                    break;
                }
            }

            if (notHex)
            {
                Console.WriteLine("Invalid input. Enter the hexadecimal number again.");
                input = GetHexNumber();
            }

            return input;
        }
    }
}