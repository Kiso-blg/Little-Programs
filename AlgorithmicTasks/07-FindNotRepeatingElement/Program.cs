using System;

namespace _07_FindNotRepeatingElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#OnlyUniqueV1" + Environment.NewLine);

            int[] array = new int[] { 1, 3, 6, 45, 98, 15, 14, 74, 85, 1, 3, 6, 45, 98, 33, 15, 14, 74, 85, };
            Console.WriteLine("Sequence: " + string.Join(" ", array));
            int element = 0;

            for (int i = 0; i < array.Length; i++)
            {
                element ^= array[i];
            }

            if (element != 0)
            {
                Console.WriteLine("The unique number is {0}.", element);
            }
            else
            {
                Console.WriteLine("There is no unique number.");
            }
        }
    }
}
