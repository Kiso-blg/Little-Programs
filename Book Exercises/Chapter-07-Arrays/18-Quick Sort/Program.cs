using System;

namespace _18_Quick_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 18" + Environment.NewLine);

            Console.WriteLine("This program sorts array of integer elements using Merge Sort algorithm.");
            int[] sequence = CreateArray();
            Console.WriteLine(string.Join(" ", sequence) + Environment.NewLine);

            QuickSort(sequence, 0, sequence.Length - 1);
            Console.WriteLine(string.Join(" ", sequence));
        }

        private static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = GetPartitionIndex(array, low, high);
                QuickSort(array, low, partitionIndex - 1);
                QuickSort(array, partitionIndex + 1, high);
            }
        }

        private static int GetPartitionIndex(int[] array, int low, int high)
        {
            int pivot = array[high];
            int lowIndex = low - 1;
            int swap;

            for (int i = low; i < high; i++)
            {
                if (array[i] <= pivot)
                {
                    lowIndex++;

                    swap = array[lowIndex];
                    array[lowIndex] = array[i];
                    array[i] = swap;
                }
            }

            swap = array[lowIndex + 1];
            array[lowIndex + 1] = array[high];
            array[high] = swap;

            return lowIndex + 1;
        }

        private static int[] CreateArray()
        {
            Random rand = new Random();
            int len = rand.Next(20, 200);
            int[] arr = new int[len];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 300);
            }

            return arr;
        }
    }
}
