using System;

namespace _13_ConvertIntoAnyNumeralSystem
{
    class Program
    {
        static readonly char[] hexNumbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-8-numeral-systems/#_Toc362296443");
            Console.WriteLine("Exercise 13" + Environment.NewLine);

            Console.WriteLine("This program converts the number N from S-based numeral system to D-based numeral system by given S, N, D (2 <= S, D <= 16).");
            Console.Write("Enter the type of the S-based numeral system: ");
            uint s = GetNumber();
            Console.Write($"Enter a number in {s}-based numeral system: ");
            string sBasedNumber = GetSBasedNumber(s);
            Console.Write("Enter the type of the D-based numeral system: ");
            uint d = GetNumber();
            uint decNumber = GetDecimalNumber(sBasedNumber, s);
            string dBasedNumber = ConvertToDBasedNumber(decNumber, d);
            Console.WriteLine();
            Console.WriteLine($"The number {sBasedNumber} in {s}-based numeral system is {dBasedNumber} in {d}-based numeral system.");
        }

        private static string ConvertToDBasedNumber(uint decNumber, uint d)
        {
            string number = string.Empty;
            uint n = decNumber;

            while (n > 0)
            {
                number += hexNumbers[n % d];
                n /= d;
            }

            char[] inCharArray = number.ToCharArray();
            Array.Reverse(inCharArray);
            string str = new string(inCharArray);

            return str;
        }

        private static uint GetDecimalNumber(string strNumber, uint s)
        {
            double num = 0;
            int pow = strNumber.Length - 1;

            for (int i = 0; i < strNumber.Length; i++)
            {
                int multiplier = (int)char.GetNumericValue(strNumber[i]);
                num += multiplier * Math.Pow(s, pow);
                pow--;
            }

            return (uint)num;
        }

        private static string GetSBasedNumber(uint s)
        {
            string input = Console.ReadLine();
            bool invalid = false;

            for (int i = 0; i < input.Length; i++)
            {
                int idx = Array.IndexOf(hexNumbers, input[i]);

                if (idx >= s)
                {
                    invalid = true;
                    break;
                }
            }

            if (invalid)
            {
                Console.WriteLine("Invalid input. Enter the number again.");
                input = GetSBasedNumber(s);
            }

            return input;
        }

        private static uint GetNumber()
        {
            string input = Console.ReadLine();

            if (!uint.TryParse(input, out uint num))
            {
                Console.WriteLine("Invalid input. Enter the number again");
                num = GetNumber();
            }

            if (num < 2 || num > 16)
            {
                Console.WriteLine("Invalid input. Enter the number again");
                num = GetNumber();
            }

            return num;
        }
    }
}