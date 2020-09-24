using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_DepthOfTree
{
    class BinaryTree
    {
        public Node Root { get; set; }

        public int MaxDepth(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                int leftDepth = MaxDepth(node.Left);
                int rightDepth = MaxDepth(node.Right);

                if (leftDepth > rightDepth)
                {
                    return leftDepth + 1;
                }
                else
                {
                    return rightDepth + 1;
                }

                //return Math.Max(leftDepth, rightDepth) + 1;
            }
        }
    }
}
