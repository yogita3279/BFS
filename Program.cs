﻿using System;
using System.Xml;

namespace BFS
{


    partial class Program
    {
      
        static Node createTree() {

            Node root = (new Node("A",
                            new Node("B", 
                                new Node("C"), new Node("D")),
                                      new Node("E",
                                         new Node("F"),
                                         new Node("G",
                                             new Node("H"), (null)))));

            return root;

        
        }
        static void Main(string[] args)
        {

            Node tree = createTree();
            Console.WriteLine("================BFS=============");
            BFSTraversal.traversBFS(tree);
        }
    }
}
