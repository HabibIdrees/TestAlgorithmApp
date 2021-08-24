using java.util;
using Nito.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithmApp.Algorithms.Trees
{
    public class LevelOrderTraversal
    {

      
        public static void levelOrder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Deque<Node> queue = new Deque<Node>();

            queue.AddToFront(root);

            while (queue.Count > 0)
            {
                Node node = queue.RemoveFromFront();  // remove from Q and assigns to node

                //process node
                Console.WriteLine(node.val + " ");

                Node leftNode = node.left;
                Node rightNode = node.right;

                if (leftNode != null)
                {
                    queue.AddToBack(leftNode); //puts the end of the Q
                }
                if (rightNode != null)
                {
                    queue.AddToBack(rightNode);
                }
            }

        }
        public static void PrintInOrder(Node node)
        {
            if (node == null)
            {
                return;
            }

            PrintInOrder(node.left);
            Console.WriteLine(node.val + ", ");
            PrintInOrder(node.right);
        }




    }
}
