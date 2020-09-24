using System;

namespace _07_ConvertHexadecimalToDecimal
{
    class Program
    {
        static readonly char[] hexNumbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        static void Main(string[] args)
        {
            Console.WriteLine("This program convers a given hexadecimal number to decimal one.");
            Console.Write("Enter a hexadecimal number: ");
            string hexNumber = GetHexNumber();
            long decNumber = GetDecimalNumber(hexNumber);
            Console.WriteLine($"The hexadecimal numumber 0x{hexNumber} in decimal numeral system is {decNumber}.");
        }

        private static long GetDecimalNumber(string hexNumber)
        {
            long number = 0;
            long pow = 1;

            for (int i = hexNumber.Length - 1; i > -1; i--)
            {
                number += (long)Array.IndexOf(hexNumbers, hexNumber[i]) * pow;
                pow *= 16;
            }

            return number;
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