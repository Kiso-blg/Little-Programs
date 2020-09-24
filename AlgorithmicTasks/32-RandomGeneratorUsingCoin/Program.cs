using System;
using System.Collections.Generic;

namespace _32_RandomGeneratorUsingCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#CoinRandom" + Environment.NewLine);

            Console.WriteLine("Enter the number of tosses of the coin.");
            int tossesCount = GetTossesCount();
            List<decimal> numbers = new List<decimal>();
            List<string> headsAndTails = new List<string>();
            GenerateNumbers(numbers, tossesCount, headsAndTails);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"{headsAndTails[i]}: {numbers[i]}");
            }
        }

        private static void GenerateNumbers(List<decimal> numbers, int tossesCount, List<string> headsAndTails)
        {
            decimal min = 0;
            decimal max = 1;
            Random randToss = new Random();
            for (int i = 0; i < tossesCount; i++)
            {
                int toss = randToss.Next(0, 1000);
                decimal number = (max + min) / 2;
                numbers.Add(number);

                if ((toss & 1) == 0)
                {
                    min = number;
                    headsAndTails.Add("Head");
                }
                else
                {
                    max = number;
                    headsAndTails.Add("Tail");
                }
            }
        }

        private static int GetTossesCount()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int count))
            {
                count = GetTossesCount();
            }

            return count;
        }
    }
}