using System;
using System.Collections.Generic;

namespace _04_FindingLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#IsThereACycle" + Environment.NewLine);

            SingleLinkedList<int> list = new SingleLinkedList<int>();
            Random rand = new Random();
            int count = rand.Next(0, 200);

            for (int i = 0; i < count; i++)
            {
                list.InsertLast(i);
            }

            list.PrintList();
            AddLastNode(list, rand.Next(0, 19));

            bool isCircular = IsListCircular(list);

            if (isCircular)
            {
                Console.WriteLine("There is eternal loop.");
            }
            else
            {
                Console.WriteLine("There is no eternal loop.");
                list.PrintList();
            }
        }

        private static void AddLastNode(SingleLinkedList<int> listt, int roll)
        {
            Node<int> lastNode = listt.GetLastNode();
            int last = lastNode.Data + 1;

            if ((roll & 1) == 0)
            {
                listt.AddNode(new Node<int>(last));
            }
            else
            {
                listt.AddNode(new Node<int>(last, listt.Head.Next));
            }

        }

        private static bool IsListCircular(SingleLinkedList<int> listt)
        {
            Node<int> oneStep = listt.Head;
            Node<int> twoSteps = listt.Head;

            for (; oneStep.Next != null; oneStep = oneStep.Next)
            {
                if (twoSteps.Next != null)
                {
                    twoSteps = twoSteps.Next;
                }
                else
                {
                    break;
                }

                if (twoSteps.Next != null)
                {
                    twoSteps = twoSteps.Next;
                }
                else
                {
                    break;
                }

                if (oneStep.Data == twoSteps.Data)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsListCircular(LinkedList<int> list)
        {
            LinkedListNode<int> slowNode = list.First.Next;
            LinkedListNode<int> fastNode = slowNode.Next;

            //while (fastNode.Next != null && fastNode.Next.Next != null)
            while (true)
            {
                if (slowNode == fastNode)
                {
                    return true;
                }

                slowNode = slowNode.Next ?? list.First;

                if (fastNode.Next != null)
                {
                    fastNode = fastNode.Next.Next ?? list.First;
                }
                else
                {
                    fastNode = list.First;
                }
            }
        }
    }
}