using System;

namespace _05_ZeroSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#ZeroSum" + Environment.NewLine);

            int[] array = new int[] { 7, -5, 2, 3, -4, -4, 2, 0, 1, -6 };
            Console.WriteLine("Sequence: " + string.Join(" ", array));
            SortArray(array);
            FindThreeElementsWithZeroSum(array);
        }

        private static void FindThreeElementsWithZeroSum(int[] array)
        {
            int foundCount = 0;

            for (int left = 0; left < array.Length - 1; left++)
            {
                int mid = left + 1;
                int right = array.Length - 1;

                while (mid != right)
                {
                    int num1 = array[left];
                    int num2 = array[mid];
                    int num3 = array[right];
                    int sum = num1 + num2 + num3;

                    if (sum == 0)
                    {
                        foundCount++;
                        Console.WriteLine($"{array[left]} + {array[mid]} + {array[right]} = 0");
                        mid++;
                    }
                    else if (sum < 0)
                    {
                        mid++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            Console.WriteLine("There are {0} intervals with sum of 3 numbers equal to 0.", foundCount);
        }

        private static void SortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int swap = array[i];
                        array[i] = array[j];
                        array[j] = swap;
                    }
                }
            }
        }
    }
}
