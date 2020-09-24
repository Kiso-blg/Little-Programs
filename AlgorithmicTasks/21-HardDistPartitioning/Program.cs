using System;

namespace _21_HardDistPartitioning
{
    class Program
    {
        const int Max = 4096;

        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#Partition" + Environment.NewLine);
            Console.WriteLine("This solution does not work properly.");
            Console.WriteLine();

            Console.WriteLine("Enter hard dist size. Size must be 4096 maximum.");
            uint hddSize = GetSize(4097u);
            Console.WriteLine($"Enter minimum partition size. Partition size must be less or equal to {hddSize}");
            uint minPartitionSize = GetSize(hddSize);

            bool[] vis = new bool[Max];
            ulong[] dyn = new ulong[Max];
            uint rem = hddSize - minPartitionSize;
            ulong result = CountPartitions(rem, minPartitionSize, vis, dyn);
            Console.WriteLine($"You can separate HDD with size {hddSize} and minimum partition size {minPartitionSize} by {result} different ways.");
        }

        private static ulong CountPartitions(uint rem, uint minPartitionSize, bool[] vis, ulong[] dyn)
        {
            if (rem == 0)
            {
                return 1;
            }

            if (rem < minPartitionSize)
            {
                return 0;
            }

            if (vis[rem])
            {
                return dyn[rem];
            }

            ulong answer = 0;

            for (uint use = minPartitionSize; use <= rem; use++)
            {
                answer += CountPartitions(rem - use, minPartitionSize, vis, dyn);
            }

            vis[rem] = true;
            dyn[rem] = answer;

            return dyn[rem];
        }

        private static uint GetSize(uint indicator)
        {
            string input = Console.ReadLine();

            if (!uint.TryParse(input, out uint size))
            {
                Console.WriteLine("Incorrect input. Try again.");
                size = GetSize(indicator);
            }

            if (indicator == 4097)
            {
                if (size > 4096)
                {
                    Console.WriteLine("Incorrect input. Try again.");
                    size = GetSize(indicator);
                }
            }
            else
            {
                if (size > indicator)
                {
                    Console.WriteLine("Incorrect input. Try again.");
                    size = GetSize(indicator);
                }
            }

            return size;
        }
    }
}