using System;

namespace _10_BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-5-conditional-statements/#_Toc362296414");
            Console.WriteLine("Exercise 10" + Environment.NewLine);

            Console.WriteLine("This program applies bonus points to a given score in range 1-9.");
            Console.Write("Enter points between 1 and 9: ");
            int points = GetNumber();
            bool correctPoints = true;

            if (points > 0 && points < 4)
            {
                points *= 10;
            }
            else if (points > 3 && points < 7)
            {
                points *= 100;
            }
            else if (points > 6 && points < 10)
            {
                points *= 1000;
            }
            else
            {
                Console.WriteLine("Error! Incorrect points count.");
                correctPoints = false;
            }

            if (correctPoints)
            {
                Console.WriteLine($"Your points are {points}");
            }
        }

        private static int GetNumber()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetNumber();
            }

            return num;
        }
    }
}