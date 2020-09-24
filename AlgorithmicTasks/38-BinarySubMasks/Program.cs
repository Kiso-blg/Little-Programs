using System;

namespace _38_BinarySubMasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#Bitmasks" + Environment.NewLine);

            Console.WriteLine("Enter binary mask. (integer)");
            int mask = GetSetsCount();
            int intLength = mask.ToString().Length;
            int maskPadding = Convert.ToString(mask, 2).Length;
            int subsetsCount = 0;

            for (int subSet = mask; subSet > 0; subSet = ((subSet - 1) & mask))
            {
                Console.WriteLine($"{Convert.ToString(subSet).PadRight(intLength, ' ')} : {Convert.ToString(subSet, 2).PadLeft(maskPadding, '0')}");
                subsetsCount++;
            }

            Console.WriteLine($"There are {subsetsCount} subsets of the binary mask.");
        }

        private static int GetSetsCount()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Incorrect input.");
                num = GetSetsCount();
            }

            return num;
        }
    }
}