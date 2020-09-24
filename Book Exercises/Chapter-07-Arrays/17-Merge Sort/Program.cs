using System;

namespace _17_Merge_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program sorts array of integer elements using Merge Sort algorithm.");
            int[] sequence = CreateArray();
            Console.WriteLine(string.Join(" ", sequence) + Environment.NewLine);

            MergeSort(sequence, 0, sequence.Length - 1);
            Console.WriteLine(string.Join(" ", sequence));
        }

        private static void MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);
                Merge(input, left, middle, right);
            }
        }

        private static void Merge(int[] array, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(array, left, leftArray, 0, leftArray.Length);
            Array.Copy(array, middle + 1, rightArray, 0, rightArray.Length);

            int l = 0;
            int r = 0;
            int k = left;

            while (l < leftArray.Length && r < rightArray.Length)
            {
                if (leftArray[l] <= rightArray[r])
                {
                    array[k] = leftArray[l];
                    l++;
                }
                else
                {
                    array[k] = rightArray[r];
                    r++;
                }

                k++;
            }

            while (l < leftArray.Length)
            {
                array[k] = leftArray[l];
                l++;
                k++;
            }

            while (r < rightArray.Length)
            {
                array[k] = rightArray[r];
                r++;
                k++;
            }
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