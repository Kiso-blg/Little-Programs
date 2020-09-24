using System;

namespace _11_RandomShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#RandomShuffle" + Environment.NewLine);

            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Sequence: " + string.Join(" ", array));
            ShuffleElements(array);
            Console.WriteLine(string.Join(" ", array));
        }

        private static void ShuffleElements(int[] array)
        {
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int pos = rand.Next(0, array.Length -1);
                int swap = array[i];
                array[i] = array[pos];
                array[pos] = swap;
            }
        }
    }
}