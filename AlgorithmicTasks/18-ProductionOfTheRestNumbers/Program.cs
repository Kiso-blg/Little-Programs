using System;
using System.Dynamic;

namespace _18_ProductionOfTheRestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#MultiplyTheOthers" + Environment.NewLine);

            ulong[] sequence = GenerateArray();
            Console.WriteLine("Sequence: " + string.Join(" ", sequence));
            int index = GetIndex(sequence.Length) - 1; 

            ulong productionOfNumbers = 1;

            for (int i = 0; i < index; i++)
            {
                productionOfNumbers *= sequence[i];
            }

            for (int i = index + 1; i < sequence.Length; i++)
            {
                productionOfNumbers *= sequence[i];
            }

            Console.WriteLine($"The product of all numbers excluding {sequence[index]} is {productionOfNumbers}");
        }

        private static int GetIndex(int length)
        {
            Console.WriteLine("Enter a number between 0 and {0}", length);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int idx))
            {
                if (idx < 0 || idx > 30)
                {
                    Console.WriteLine("Incorrect input.");
                    idx = GetIndex(length);
                }
            }
            else
            {
                Console.WriteLine("Incorrect input.");
                idx = GetIndex(length);
            }

            return idx;
        }

        private static ulong[] GenerateArray()
        {
            ulong[] array = new ulong[10];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (ulong)rand.Next(0, 30);
            }

            return array;
        }
    }
}