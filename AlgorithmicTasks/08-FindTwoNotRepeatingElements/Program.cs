using System;

namespace _08_FindTwoNotRepeatingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#OnlyUniqueV2" + Environment.NewLine);

            int[] array = new int[] { 1, 3, 6, 45, 98, 15, 14, 74, -85, 1, 3, 6, 45, 1, 98, 33, 15, 14, 74, -85 };
            Console.WriteLine("Sequence: " + string.Join(" ", array));
            int element = 0;

            for (int i = 0; i < array.Length; i++)
            {
                element ^= array[i];
            }

            int bitPosition = 1;           

            while (((element >> 1) & 1) != 1)
            {
                element >>= 1;
                bitPosition++;
            }

            int firstNotRepeatingNum = 0;
            int secondNotRepeatingNum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (((array[i] >> bitPosition) & 1) == 1)
                {
                    firstNotRepeatingNum ^= array[i];
                }
                else
                {
                    secondNotRepeatingNum ^= array[i];
                }
            }

            Console.WriteLine($"The unique non repeating numbers are {firstNotRepeatingNum} and {secondNotRepeatingNum}");
        }
    }
}
