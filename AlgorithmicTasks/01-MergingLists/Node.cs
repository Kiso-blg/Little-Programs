namespace _01_MergingLists
{
    internal class Node<T>
    {
        internal T Data;
        internal Node<T> Next;

        public Node(T data)
        {
            this.Data = data;
            this.Next = null;
        }

        public Node(T data, Node<T> next)
        {
            this.Data = data;
            this.Next = next;
        }
    }
}