using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
    class BFSTraversal
    {
       public  static void traversBFS(Node node) {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                Console.WriteLine( node.data+"");

                if (node.left != null)
                {
                    queue.Enqueue(node.left);

                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);

                }

            }


        }
    }
}
