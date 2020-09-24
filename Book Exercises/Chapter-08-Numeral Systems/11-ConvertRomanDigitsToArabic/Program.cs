using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_ConvertRomanDigitsToArabic
{
    class Program
    {
        static readonly Dictionary<char, int> RomanNumbers = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        static void Main(string[] args)
        {
            Console.WriteLine("This program converts a given Roman number to Arabic one using symbols M, D, C, L, X, V, I.");
            int arabicNumber = GetArabicNumber();
            Console.WriteLine($"The number is {arabicNumber}.");
        }

        private static int GetArabicNumber()
        {
            string romanNumber = Console.ReadLine().ToUpper();
            int number = 0;
            bool invalid = false;
            int value;
            int lastValue = 0;
            int biggestValue = 0;

            for (int i = romanNumber.Length - 1; i > -1; i--)
            {
                char letter = romanNumber[i];

                if (RomanNumbers.Keys.Contains(letter))
                {
                    value = RomanNumbers[letter];
                }
                else
                {
                    invalid = true;
                    break;
                }


                if (value < lastValue)
                {
                    biggestValue = lastValue;

                    if ((lastValue == 1000 && value == 100) ||
                        (lastValue == 500 && value == 100) ||
                        (lastValue == 100 && value == 10) ||
                        (lastValue == 50 && value == 10) ||
                        (lastValue == 10 && value == 1) ||
                        (lastValue == 5 && value == 1))
                    {
                        value *= -1;
                    }
                    else
                    {
                        invalid = true;
                        break;
                    }
                }
                else if (value == lastValue)
                {
                    if (value == 500 || value == 50 || value == 5)
                    {
                        invalid = true;
                        break;
                    }
                }
                else
                {
                    if (biggestValue > value)
                    {
                        invalid = true;
                        break;
                    }
                }

                number += value;
                lastValue = value;
            }

            if (invalid)
            {
                Console.WriteLine("Invalid input. Try again");
                number = GetArabicNumber();
            }

            return number;
        }
    }
}