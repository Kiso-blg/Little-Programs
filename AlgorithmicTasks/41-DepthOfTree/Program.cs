using System;

namespace _41_DepthOfTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#DepthOfTree" + Environment.NewLine);

            BinaryTree tree = new BinaryTree
            {
                Root = new Node(1)
            };
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Left.Left.Left = new Node(6);
            tree.Root.Left.Left.Right = new Node(7);

            Console.WriteLine("Height of the tree is: " + tree.MaxDepth(tree.Root));
        }
    }
}