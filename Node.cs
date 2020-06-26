using System;
using System.Collections.Generic;
using System.Text;

namespace BFS
{
   public  class Node
    {
        public String data;
        public Node left;
        public Node right;
       public Node(String data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right;

        }
       public  Node(String data) {
            this.data = data;
            this.left = null;
            this.right = null;
        }

    }
}
