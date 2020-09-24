using System;

namespace _01_MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#MergingLists" + Environment.NewLine);

            Random rand = new Random();
            int count = rand.Next(15, 20);
            int diff = 0;
            SingleLinkedList<int> firstList = GenerateLinkedList(count, diff);
            firstList.PrintList();
            Console.WriteLine();
            
            count = rand.Next(1, 15);
            diff = rand.Next(firstList.Count - count, firstList.Count - count + 2);
            //int diff = firstList.Count - count + 1;
            SingleLinkedList<int> secondList = GenerateLinkedList(count, diff);
            secondList.PrintList();
            Console.WriteLine();

            bool areMerging = CheckIfListAreMerging(firstList, secondList, out int element);

            if (areMerging)
            {
                Console.WriteLine($"The lists are merging at element {element}.");
            }
            else
            {
                Console.WriteLine("The lists are not merging.");
            }
        }

        private static bool CheckIfListAreMerging(SingleLinkedList<int> firstList, SingleLinkedList<int> secondList, out int element)
        {
            int start = firstList.Count - secondList.Count;
            Node<int> firstListNode = firstList.Head;
            Node<int> secondListNode = secondList.Head;
            bool areEqual = false;
            int elm = -1;

            for (int i = 0; i <= firstList.Count; i++)
            {
                if (i >= start)
                {
                    Console.WriteLine($"firstListNode: {firstListNode.Data}  |  secondListNode: {secondListNode.Data}");

                    if (firstListNode.Data == secondListNode.Data)
                    {
                        if (!areEqual)
                        {
                            elm = firstListNode.Data;
                        }

                        areEqual = true;
                    }
                    else
                    {
                        areEqual = false;
                    }

                    secondListNode = secondListNode.Next;
                }

                firstListNode = firstListNode.Next;
            }

            element = elm;
            return areEqual;
        }

        private static SingleLinkedList<int> GenerateLinkedList(int count, int diff)
        {
            SingleLinkedList<int> firstList = new SingleLinkedList<int>();

            for (int i = 0; i < count; i++)
            {
                firstList.InsertLast(i + diff);
            }

            return firstList;
        }
    }
}