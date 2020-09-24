using System;

namespace _12_ConvertArabicNumbersToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-8-numeral-systems/#_Toc362296443");
            Console.WriteLine("Exercise 12" + Environment.NewLine);

            Console.WriteLine("This program converts a given Arabic number to Roman one.");
            int number = GetNumber();
            int thousands = number / 1000;
            string romanNumber = new string('M', thousands);
            int hundreds = (number / 100) % 10;
            romanNumber += AddToRoman(hundreds, 'M', 'D', 'C');
            int tens = (number / 10) % 10;
            romanNumber += AddToRoman(tens, 'C', 'L', 'X');
            int units = number % 10;
            romanNumber += AddToRoman(units, 'X', 'V', 'I');

            Console.WriteLine($"The number {number} in Roman numeral system is {romanNumber}");
        }

        private static string AddToRoman(int unit, char ten, char five, char one)
        {
            string toRoman = string.Empty;

            if (unit == 9)
            {
                toRoman += one + "" + ten;
            }
            else if (unit == 5)
            {
                toRoman += five;
            }
            else if (unit == 4)
            {
                toRoman += one + "" + five;
            }
            else if (unit > 5)
            {
                toRoman += five + new string(one, unit - 5);
            }
            else
            {
                toRoman += new string(one, unit);
            }

            return toRoman;
        }

        private static int GetNumber()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Invalid input. Enter the number again");
                num = GetNumber();
            }

            return Math.Abs(num);
        }
    }
}