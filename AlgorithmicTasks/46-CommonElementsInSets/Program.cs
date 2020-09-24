using System;
using System.Collections.Generic;
using System.Linq;

namespace _46_CommonElementsInSets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#SetIntersection" + Environment.NewLine);

            Console.Write("Enter the length of the first array: ");
            int firstArrayLen = GetLength();
            Console.Write("Enter the length of the second array: ");
            int secondArrayLen = GetLength();
            int[] arr1 = GenerateArray(firstArrayLen);
            int[] arr2 = GenerateArray(secondArrayLen);
            Console.WriteLine($"First array:  {string.Join(" ", arr1)}");
            Console.WriteLine($"Second array:  {string.Join(" ", arr2)}");
            FindCommonElementsInSortedArrays(arr1, arr2);
            FindCommonElementsInNonSortedArrays(arr1, arr2);
        }

        private static int GetLength()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                num = GetLength();
            }

            return num;
        }

        private static void FindCommonElementsInNonSortedArrays(int[] arr1, int[] arr2)
        {
            if (arr1.Length < arr2.Length)
            {
                FindCommonElements(arr1, arr2);
            }
            else
            {
                FindCommonElements(arr2, arr1);
            }
        }

        private static void FindCommonElements(int[] firstArr, int[] secondArr)
        {
            HashSet<int> commonElements = new HashSet<int>();

            for (int i = 0; i < secondArr.Length; i++)
            {
                if (firstArr.Contains(secondArr[i]))
                {
                    commonElements.Add(secondArr[i]);
                }
            }

            Console.WriteLine("Common elements in sorted arrays:");
            Console.WriteLine(string.Join(" ", commonElements.ToArray()));
        }

        private static void FindCommonElementsInSortedArrays(int[] arr1, int[] arr2)
        {
            int[] firstArr = new int[arr1.Length];
            Array.Copy(arr1, firstArr, arr1.Length);
            int[] secondArr = new int[arr2.Length];
            Array.Copy(arr2, secondArr, arr2.Length);
            Array.Sort(firstArr);
            Array.Sort(secondArr);
            int firstIdx = 0;
            int secondIdx = 0;
            HashSet<int> set = new HashSet<int>();

            while (firstIdx < firstArr.Length && secondIdx < secondArr.Length)
            {
                if (firstArr[firstIdx] == secondArr[secondIdx])
                {
                    set.Add(secondArr[secondIdx++]);

                    //while (secondIdx < secondArr.Length && firstArr[firstIdx] == secondArr[secondIdx])
                    //{
                    //    firstIdx++;
                    //    secondIdx++;
                    //}
                }
                else if (firstArr[firstIdx] < secondArr[secondIdx])
                {
                    firstIdx++;
                }
                else
                {
                    secondIdx++;
                }
            }

            Console.WriteLine("Common elements in sorted arrays:");
            Console.WriteLine(string.Join(" ", set.ToArray()));
        }

        private static int[] GenerateArray(int len)
        {
            Random rand = new Random();
            int[] arr = new int[len];

            for (int i = 0; i < len; i++)
            {
                int element = rand.Next(0, 50);
                arr[i] = element;
            }

            return arr;
        }
    }
}