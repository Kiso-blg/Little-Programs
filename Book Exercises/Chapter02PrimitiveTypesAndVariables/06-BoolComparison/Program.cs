using System;

namespace _06_BoolComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-2-primitive-types-and-variables/#_Toc362296391");
            Console.WriteLine("Exercise 6" + Environment.NewLine);

            Console.WriteLine("Enter your gender using 'M' or 'F'.");
            char gender = GetGender();

            bool isMale = gender == 'm';
            Console.WriteLine(isMale ? "Yes! You are a Man!" : "You are not a man.");
        }

        private static char GetGender()
        {
            string input = Console.ReadLine().ToLower();

            if (!char.TryParse(input, out char ch))
            {
                Console.WriteLine("Incorrect input. Try again.");
                ch = GetGender();
            }

            while (!(ch == 'm' || ch == 'f'))
            {
                Console.WriteLine("Incorrect input. Enter you gender again.");
                ch = GetGender();
            }

            return ch;
        }
    }
}