using System;

namespace _15_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 15" + Environment.NewLine);

            Console.WriteLine("This program prints the numbers of the letters in the latin alphabet by a given word.");
            string alphabet = " abcdefghijklmnopqrstuvwxyz";
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                if (Char.ToUpper(word[i]) > 64 && char.ToUpper(word[i]) < 91)
                {
                    Console.WriteLine($"{word[i]} = {alphabet.IndexOf(Char.ToLower(word[i]))}");
                }
                else
                {
                    Console.WriteLine(word[i]);
                }
            }
        }
    }
}