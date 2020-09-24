using System;

namespace _03_GetLastDigit
{
    class Program
    {
        static readonly string[] digits = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-9-methods/#_Toc362296457");
            Console.WriteLine("Exercise " + Environment.NewLine);

            Console.WriteLine("This program contains method which returns the english name of the last digit of given integer.");            
            int number = GetNumber();
            string digit = GetDigit(number);
            Console.WriteLine($"The last digit is {digit}.");
        }

        private static string GetDigit(int number)
        {
            return digits[number % 10];
        }

        private static int GetNumber()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Ivalid input. Enter the number again.");
                num = GetNumber();
            }

            return num;
        }
    }
}