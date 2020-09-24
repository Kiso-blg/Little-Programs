using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ConvertBinaryToHexadecimal
{
    class Program
    {
        static readonly string condition = "The input must contain only '0' and '1'.";
        static readonly string hexNumbers = "0123456789ABCDEF";

        static void Main(string[] args)
        {
            Console.WriteLine("This program converts a given binary number to hexadecimal one.");
            Console.WriteLine(condition);
            Console.Write("Enter a binary number: ");
            string binary = GetBinaryNumber();
            string hexNumber = ConvertToHex(binary);
            Console.WriteLine($"{binary} in hexadecimal numeral system is 0x{hexNumber}");
        }

        private static string ConvertToHex(string binary)
        {
            long number = 0;
            int pow = binary.Length - 1;

            for (int i = 0; i < binary.Length; i++)
            {
                int multiplier = (int)char.GetNumericValue(binary[i]);
                number += multiplier * (long)Math.Pow(2, pow);
                pow--;
            }

            string hex = string.Empty;

            while (number > 0)
            {
                hex = hexNumbers[(int)(number % 16)] + hex;
                number /= 16;
            }

            return hex;
        }

        private static string GetBinaryNumber()
        {
            string input = Console.ReadLine();

            if (!IsBinary(input))
            {
                Console.WriteLine("Invalid input.");
                Console.WriteLine(condition);
                input = GetBinaryNumber();
            }

            return input;
        }

        private static bool IsBinary(string input)
        {
            if (input == string.Empty)
            {
                return false;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '1' && input[i] != '0')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
