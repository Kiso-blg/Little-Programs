using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _21_All_Subsets_With_Sum_Of_K_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds subsets of an array, which have sum S.");
            Console.WriteLine("The array has elements between -30 and 30, and length between 10 and 20.");
            int[] set = GenerateArray();
            //int[] set = new int[] { 3, 1, 2, 4, 9, 6 };
            Console.WriteLine(string.Join(" ", set));
            Console.Write("Enter the sum S = ");
            int s = GetSNumber(set, "s");
            Console.Write("Enter the subset's elemets count: K = ");
            int k = GetSNumber(set, "k");            
            string strMask = GetBaseMask(set.Length);
            BigInteger intMask = GetIntMask(strMask.Length);
            int count = 0;

            while (intMask > 0)
            {
                CalcSums(set, strMask, s, k, ref count);
                intMask--;
                strMask = GetStrMask(intMask).PadLeft(set.Length, '0');
            }

            if (count == 0)
            {
                Console.WriteLine("No subsets were found.");
            }
            else
            {
                Console.WriteLine($"There were found {count} subsets.");
            }
        }

        private static int GetSNumber(int[] set, string sigh)
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Invalid input. Enter the number again.");
                num = GetSNumber(set, sigh);
            }

            if (sigh == "k")
            {
                if (num < 0 || num > set.Length - 1)
                {
                    Console.WriteLine("Invalid input. Enter the number again.");
                    num = GetSNumber(set, sigh);
                }
            }

            return num;
        }

        private static int[] GenerateArray()
        {
            Random rand = new Random();
            int[] array = new int[rand.Next(10, 20)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-30, 30);
            }

            return array;
        }

        private static string GetStrMask(BigInteger intMask)
        {
            string mask = string.Empty;

            while (intMask > 0)
            {
                mask = (intMask % 2) + mask;
                intMask /= 2;
            }

            return mask;
        }

        private static void CalcSums(int[] set, string strMask, int s, int k, ref int count)
        {
            int sum = 0;
            List<int> indexes = new List<int>();

            for (int i = 0; i < strMask.Length; i++)
            {
                if (strMask[i] == '1')
                {
                    sum += set[i];
                    indexes.Add(i);
                }

                if (indexes.Count > k)
                {
                    break;
                }
            }

            if (indexes.Count == k)
            {
                if (sum == s)
                {
                    string result = set[indexes[0]].ToString();

                    for (int j = 1; j < indexes.Count; j++)
                    {
                        result += " + " + set[indexes[j]];
                    }

                    result += $" = {s}";
                    Console.WriteLine(result);
                    count++;
                }
            }
        }

        private static BigInteger GetIntMask(int length)
        {
            BigInteger num = 0;

            for (int i = 0; i < length; i++)
            {
                num += (BigInteger)Math.Pow(2, i);
            }

            return num;
        }

        private static string GetBaseMask(int length)
        {
            string mask = string.Empty;

            for (int i = 0; i < length; i++)
            {
                mask += "1";
            }

            return mask;
        }
    }
}
