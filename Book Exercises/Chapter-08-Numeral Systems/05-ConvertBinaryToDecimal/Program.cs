using System;

namespace _05_ConvertBinaryToDecimal
{
    class Program
    {
        static readonly string condition = "The input must contain only '0' and '1'.";

        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-8-numeral-systems/#_Toc362296443");
            Console.WriteLine("Exercise 5" + Environment.NewLine);

            Console.WriteLine("This program converts a given binary number to decimal one.");
            Console.WriteLine(condition);
            Console.Write("Enter a binary number: ");
            string binary = GetBinaryNumber();
            int number = ConvertToDecimal(binary);
            Console.WriteLine($"The binary number {binary} is {number} in decimal numeral system.");
        }

        private static int ConvertToDecimal(string binary)
        {
            double number = 0;
            int pow = binary.Length - 1;

            for (int i = 0; i < binary.Length; i++)
            {
                int multiplier = (int)char.GetNumericValue(binary[i]);
                number += multiplier * Math.Pow(2, pow);
                pow--;
            }

            return (int)number;
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