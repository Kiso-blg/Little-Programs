using System;
using System.Collections.Generic;
using System.Linq;

namespace _24_Combinations_Of_K_Elements
{
    class Program
    {
        static readonly HashSet<string> combinations = new HashSet<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 24" + Environment.NewLine);

            Console.WriteLine("This program prints all variations of K elemets with increasing elements of numbers in interval 1-N by given K and N.");
            Console.Write("Enter a number in range 1-9: N = ");
            int n = GetNumber();
            Console.Write("Enter a number in range 1-9: K = ");
            int k = GetNumber();

            int[] arr = new int[k];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            combinations.Add($"{{{string.Join(", ", arr)}}}");
            Console.WriteLine(string.Join(", ", arr));

            for (int i = arr.Length - 1; i > -1; i--)
            {
                IncreaseElements(n, arr, i);
            }

            foreach (string combination in combinations.OrderBy(item => item))
            {
                Console.WriteLine(combination);
            }

            Console.WriteLine($"There are {combinations.Count} combinations.");
        }

        private static void IncreaseElements(int n, int[] arr, int idx)
        {
            int[] newArr = arr.Take(arr.Length).ToArray();

            while (newArr[newArr.Length - 1] < n)
            {
                for (int j = idx; j < arr.Length; j++)
                {
                    newArr[j]++;
                }

                Console.WriteLine(string.Join(", ", newArr));
                combinations.Add($"{{{string.Join(", ", newArr)}}}");

                if (idx < newArr.Length - 1)
                {
                    for (int i = newArr.Length - 1; i >= idx; i--)
                    {
                        IncreaseElements(n, newArr, i);
                    }
                }
            }
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