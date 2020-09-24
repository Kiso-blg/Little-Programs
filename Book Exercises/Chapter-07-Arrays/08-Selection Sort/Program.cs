using System;

namespace _08_Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 8" + Environment.NewLine);

            Console.WriteLine("This program sorts a randomly genereted array using Selection Sort algorithm and prints it.");            
            int[] sequence = GenerateArray();
            Console.WriteLine("Sequence: " + string.Join(" ", sequence));
            Console.WriteLine();
            SortArray(sequence);
            Console.WriteLine("Sorted sequence: " + string.Join(" ", sequence));
        }

        private static void SortArray(int[] sequence)
        {
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                int lowestIndex = i;

                for (int j = i + 1; j < sequence.Length; j++)
                {
                    if (sequence[j] < sequence[lowestIndex])
                    {
                        lowestIndex = j;
                    }
                }

                int swap = sequence[lowestIndex];
                sequence[lowestIndex] = sequence[i];
                sequence[i] = swap;
            }
        }

        private static int[] GenerateArray()
        {
            Random rand = new Random();
            int len = rand.Next(10, 40);
            int[] arr = new int[len];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }

            return arr;
        }
    }
}