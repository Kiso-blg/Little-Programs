using System;

namespace _45_CreatePalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#PalindromeV2" + Environment.NewLine);

            Console.WriteLine("Enter a string.");
            string input = Console.ReadLine();
            string palindrome = CreatePalindrome(input);
            Console.WriteLine("Closest palindrome is: " + palindrome);
        }

        private static string CreatePalindrome(string input)
        {
            char[] array = input.ToCharArray();
            int len = array.Length;

            for (int i = 0; i < array.Length / 2; i++)
            {
                char left = array[i];
                char right = array[len - 1 - i];

                if (right < left)
                {
                    array[i] = right;
                    array[len - 1 - i] = right;
                }
                else
                {
                    array[i] = left;
                    array[len - 1 - i] = left;
                }
            }

            return new string(array);
        }
    }
}