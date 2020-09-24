using System;

namespace _05_DigitAsAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-5-conditional-statements/#_Toc362296414");
            Console.WriteLine("Exercise 5" + Environment.NewLine);

            Console.WriteLine("This program prints a given digit (0-9) as a word using switch statement.");
            Console.Write("Enter a digit: ");
            int digit = GetDigit();

            switch (digit)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
            }
        }

        private static int GetDigit()
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int num))
            {
                if (input.Length > 1)
                {
                    Console.WriteLine("The input must be 1 digit. Try again.");
                    num = GetDigit();
                }
            }
            else
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetDigit();
            }

            return num;
        }
    }
}