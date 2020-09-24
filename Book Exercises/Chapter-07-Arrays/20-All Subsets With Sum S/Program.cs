using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Text;

namespace _20_All_Subsets_With_Sum_S
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 20" + Environment.NewLine);

            Console.WriteLine("This program finds subsets of an array, which have sum S.");
            Console.WriteLine("The array has elements between -30 and 30, and length between 10 and 20.");
            int[] set = GenerateArray();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Join(" ", set));
            Console.WriteLine(sb);
            Console.Write("Enter the sum S = ");
            int s = GetSNumber();
            //int[] set = new int[] { 2, 1, 2, 4, 3, 5, 2, 6 };
            //int[] set = new int[] { 14 };            
            string strMask = GetBaseMask(set.Length);
            BigInteger intMask = GetIntMask(strMask.Length);            
            int count = 0;            

            while (intMask > 0)
            {
                CalcSums(set, strMask, s, ref count, sb);
                intMask--;
                strMask = GetStrMask(intMask).PadLeft(set.Length, '0');
            }

            if (count == 0)
            {
                Console.WriteLine("No subsets were found.");
            }
            else
            {
                string filePath = Environment.CurrentDirectory;
                File.WriteAllText(filePath + "Combinations.txt", sb.ToString());
                Console.WriteLine($"There were found {count} subsets.");
                Process.Start(filePath + "Combinations.txt");
            }
        }

        private static int GetSNumber()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Invalid input. Enter the number again.");
                num = GetSNumber();
            }

            //if (num < -50 || num > 50)
            //{
            //    Console.WriteLine("Invalid input. Enter the number again.");
            //    num = GetSNumber();
            //}

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

        private static void CalcSums(int[] set, string strMask, int s, ref int count, StringBuilder sb)
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
            }

            if (sum == s)
            {
                string result = set[indexes[0]].ToString();

                for (int j = 1; j < indexes.Count; j++)
                {
                    result += " + " + set[indexes[j]];
                }

                result += $" = {s}";
                Console.WriteLine(result);
                sb.AppendLine(result);
                count++;
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