namespace _41_DepthOfTree
{
    class Node
    {
        public Node(int data)
        {
            this.Data = data;
            this.Left = this.Right = null;
        }

        public int Data { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }
    }
}