using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_FindRepeatingElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#RepeatedElement" + Environment.NewLine);

            int[] array = new int[] { 5, 3, 1, 4, 2, 3, 6 };
            Console.WriteLine("Sequence: " + string.Join(" ", array));
            bool foundRepeatingElement = false;
            int position = -1;

            for (int i = 0; i < array.Length; i++)
            {
                int element = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == element)
                    {
                        foundRepeatingElement = true;
                        position = j;
                    }
                }
            }

            if (foundRepeatingElement)
            {
                Console.WriteLine("There is repeating element at position {0}.", position);
            }
            else
            {
                Console.WriteLine("There is no repeating element found.");
            }
        }
    }
}
