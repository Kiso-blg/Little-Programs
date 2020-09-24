using System;
using System.Collections.Generic;
using System.Linq;

namespace _26_All_Permutations
{
    class Program
    {
        static readonly HashSet<int[]> permutations = new HashSet<int[]>();

        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/intro-csharp-book/read-online/glava7-masivi/#_Toc298864093");
            Console.WriteLine("Exercise 23" + Environment.NewLine);

            Console.WriteLine("This program prints all the permutations of the number 1...N by given N.");
            Console.Write("Enter a number in range 1-9: N = ");
            int n = GetNumber();
            int[] arr = GetArray(n);
            int start = 0;
            GetPermutations2(start, arr);

            foreach (int[] array in permutations)
            {
                Console.WriteLine($"{{{string.Join(", ", array)}}}");
            }
        }

        private static void GetPermutations2(int start, int[] arr)
        {
            if (start == arr.Length)
            {
                permutations.Add(arr);
            }

            int[] newArr = arr.Take(arr.Length).ToArray();

            for (int i = start; i < arr.Length; i++)
            {
                int swap = newArr[i];
                newArr[i] = newArr[start];
                newArr[start] = swap;
                GetPermutations2(start + 1, newArr);
            }
        }

        private static int[] GetArray(int n)
        {
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            return arr;
        }

        private static int GetNumber()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Invalid input. Enter the number again.");
                num = GetNumber();
            }

            if (num < 1 || num > 9)
            {
                Console.WriteLine("Invalid input. Enter the number again.");
                num = GetNumber();
            }

            return num;
        }
    }
}