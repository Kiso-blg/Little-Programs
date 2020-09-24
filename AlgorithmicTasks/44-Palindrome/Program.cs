using System;

namespace _44_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#PalindromeV1" + Environment.NewLine);

            Console.WriteLine("Enter a string.");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine($"{input} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome.");
            }
        }

        private static bool IsPalindrome(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}