using System;

namespace _04_DeckCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-6-loops/#_Toc362296424");
            Console.WriteLine("Exercise 4" + Environment.NewLine);

            Console.WriteLine("This program prints all cards from a standard deck.");
            string[] types = new string[] { "Spades", "Hearts", "diamonds", "Clubs"};
            string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};

            for (int i = 0; i < types.Length; i++)
            {
                Console.WriteLine($"{types[i]}:");

                for (int j = 0; j < cards.Length - 1; j++)
                {
                    Console.Write($"{cards[j]} of {types[i]}, ");
                }

                Console.WriteLine($"{cards[cards.Length - 1]} {types[i]}");
            }
        }
    }
}