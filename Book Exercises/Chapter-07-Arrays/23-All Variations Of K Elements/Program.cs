using System;
using System.Collections.Generic;
using System.Linq;

namespace _23_All_Variations_Of_K_Elements
{
    class Program
    {
        static readonly HashSet<string> set = new HashSet<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 23" + Environment.NewLine);

            Console.WriteLine("This program prints all variations of K elemets of numbers in interval 1-N by given K and N.");
            Console.Write("Enter a number N = ");
            int n = GetNumber();
            Console.Write("Enter a number K = ");
            int k = GetNumber();

            for (int i = 1; i < n; i++)
            {
                int[] arr = InitializeArray(k, i);
                set.Add($"{{{string.Join(", ", arr)}}}");
                int[] newArr = arr.Take(arr.Length).ToArray();

                for (int j = arr.Length - 1; j > -1; j--)
                {
                    for (int l = 0; l < n - i; l++)
                    {
                        newArr[j]++;
                        set.Add($"{{{string.Join(", ", arr)}}}");
                        int start = 0;
                        GetPermutations(newArr, start);
                    }
                }

                for (int h = arr.Length - 1; h > 0; h--)
                {
                    arr[h]++;
                    set.Add($"{{{string.Join(", ", arr)}}}");
                    int start = 0;
                    GetPermutations(arr, start);
                }
            }

            foreach (string item in set.OrderBy(item => item))
            {
                Console.WriteLine(item);
            }
        }

        private static void GetPermutations(int[] arr, int start)
        {
            if (start == arr.Length)
            {
                set.Add($"{{{string.Join(", ", arr)}}}");
            }

            int[] newArr = arr.Take(arr.Length).ToArray();

            for (int i = start; i < arr.Length; i++)
            {
                int swap = newArr[i];
                newArr[i] = newArr[start];
                newArr[start] = swap;
                GetPermutations(newArr, start + 1);
            }
        }

        private static int[] InitializeArray(int k, int j)
        {
            int[] arr = new int[k];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = j;
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

            return num;
        }
    }    
}