using System;

namespace _01_MergingLists
{
    internal class SingleLinkedList<T>
    {
        internal Node<T> Head;
        internal int Count;

        internal void InsertFront(T newData)
        {
            Node<T> newNode = new Node<T>(newData)
            {
                Next = this.Head
            };
            this.Head = newNode;
            this.Count = 1;
        }

        internal void InsertLast(T newData)
        {
            Node<T> newNode = new Node<T>(newData);

            if (this.Head == null)
            {
                this.Head = newNode;
                return;
            }

            Node<T> lastNode = GetLastNode();
            lastNode.Next = newNode;
            this.Count++;
        }

        internal Node<T> GetLastNode()
        {
            Node<T> temp = this.Head;

            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            return temp;
        }

        internal void AddNode(Node<T> node)
        {
            if (this.Head == null)
            {
                this.Head = node;
                return;
            }

            Node<T> lastNode = GetLastNode();
            lastNode.Next = node;
            this.Count++;
        }

        internal void InsertAfter(Node<T> prevNode, T newData)
        {
            if (prevNode == null)
            {
                Console.WriteLine("The given previous node Cannot be Null.");
                return;
            }

            Node<T> newNode = new Node<T>(newData)
            {
                Next = prevNode.Next
            };
            prevNode.Next = newNode;
            this.Count++;
        }

        internal void DeleteNodeByKey(T key)
        {
            Node<T> temp = this.Head;
            Node<T> prev = null;

            if (temp != null && (object)temp.Data == (object)key)
            {
                this.Head = temp.Next;
                return;
            }

            while (temp != null && (object)temp.Data != (object)key)
            {
                prev = temp;
                temp = temp.Next;
            }

            if (temp == null)
            {
                return;
            }

            prev.Next = temp.Next;
            this.Count--;
        }

        public void ReverseLinkedList()
        {
            Node<T> prev = null;
            Node<T> current = this.Head;

            while (current != null)
            {
                Node<T> temp = current.Next;
                current.Next = prev;
                prev = current;
                current = temp;
            }

            this.Head = prev;
        }

        public void PrintList()
        {
            Node<T> node = this.Head;

            while (node != null)
            {
                Console.Write(node.Data + " ");
                node = node.Next;
            }

            Console.WriteLine();
        }
    }
}