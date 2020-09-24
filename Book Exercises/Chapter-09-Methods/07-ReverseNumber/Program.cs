using System;

namespace _07_ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-9-methods/#_Toc362296457");
            Console.WriteLine("Exercise 7" + Environment.NewLine);

            Console.WriteLine("This program prints the digits of a given decimal number in reverse order.");
            Console.Write("Enter a number: ");
            int number = GetNumber();
            ReverseNUmber(number);
        }

        private static void ReverseNUmber(int number)
        {
            int reversedNumber = 0;

            while (number > 0)
            {
                reversedNumber += number % 10;
                reversedNumber *= 10;
                number /= 10;
            }

            reversedNumber /= 10;
            Console.WriteLine("Reversed number: " + reversedNumber);
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