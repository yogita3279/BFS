using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    class DFS
    {
       public  static void dfsTraversal(Node node) {
            Stack<Node> stack = new Stack<Node>();
            stack.Push(node);
            while (stack.Count > 0)
            {
                node = stack.Pop();
                Console.WriteLine(node.data + "");

                if (node.left != null)
                {
                    stack.Push(node.left);

                }
                if (node.right != null)
                {
                    stack.Push(node.right);

                }

            }


        }
    }
}
