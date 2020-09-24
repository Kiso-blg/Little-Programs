using System;

namespace _07_WightOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-3-operators-and-expressions/#_Toc362296398");
            Console.WriteLine("Exercise 7" + Environment.NewLine);

            Console.WriteLine("This program calculates the wight on the moon.");
            Console.Write("Enter a weight: ");
            double weight = GetWeight();
            Console.WriteLine($"The weight of {weight} on the moon is {weight * 0.17}");
        }

        private static double GetWeight()
        {
            string input = Console.ReadLine();

            if (!double.TryParse(input, out double weight))
            {
                Console.WriteLine("Incorrect input. Try again");
                weight = GetWeight();
            }

            return weight;
        }
    }
}