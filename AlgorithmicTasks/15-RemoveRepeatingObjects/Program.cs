using System;
using System.Collections.Generic;
using System.Linq;

namespace _15_RemoveRepeatingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#Unique" + Environment.NewLine);

            int[] arrayNumbers = GenerateArray();
            Console.WriteLine("Sequence: " + string.Join(" ", arrayNumbers));
            HashSet<int> nonRepeatingElements = new HashSet<int>();

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                if (!nonRepeatingElements.Contains(arrayNumbers[i]))
                {
                    nonRepeatingElements.Add(arrayNumbers[i]);
                }
            }

            Console.Write("Non-repeating elements: ");

            foreach (int number in nonRepeatingElements.OrderBy(n => n))
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }

        private static int[] GenerateArray()
        {
            int[] array = new int[300];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }

            return array;
        }
    }
}