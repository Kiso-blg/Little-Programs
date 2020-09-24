using System;

namespace _10_HornerScheme
{
    class Program
    {
        static readonly string condition = "The input must contain only '0' and '1'.";

        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-8-numeral-systems/#_Toc362296443");
            Console.WriteLine("Exercise 10" + Environment.NewLine);

            Console.WriteLine("This program converts a given binary number to decimal one using the Horner scheme.");
            Console.WriteLine(condition);
            Console.Write("Enter a binary number: ");
            string binary = GetBinaryNumber();
            long number = ConvertToDecimal(binary);
            Console.WriteLine(number);
        }

        private static long ConvertToDecimal(string binary)
        {
            long number = 2;

            for (int i = 1; i < binary.Length - 1; i++)
            {
                int bit = (int)char.GetNumericValue(binary[i]);
                number += bit;
                number *= 2;                
            }

            number +=(int)char.GetNumericValue(binary[binary.Length - 1]);

            return number;
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
