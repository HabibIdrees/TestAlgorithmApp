using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAlgorithmApp.Algorithms.Trees.Node;

namespace TestAlgorithmApp.Algorithms.Trees
{
    public class BFS
    {
        //Bread - First - Search
        //Offer Root
        //While(!Que.isEmpty)
        //  {
        //      poll() From Q
        //      Process current node
        //      Offer children of current node to the end of Q
        //   }








        public static void LevelOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                Node node = queue.Dequeue();

                //process node
                Console.WriteLine(node.val);

                Node leftNode = node.left;
                Node rightNode = node.right;

                if (leftNode !=null)
                {
                    queue.Enqueue(leftNode);
                }
                if (rightNode != null)
                {
                    queue.Enqueue(rightNode);
                }

            }



        }




              public static void Main(String[] args)
        {
            Node root = new Node(val: 0);
            Node n1 = new Node(val: 1);
            Node n2 = new Node(val: 2);
            Node n3 = new Node(val: 3);
            Node n4 = new Node(val: 4);
            root.left = n1;
            root.right = n2;
            n1.left = n3;
            n2.right = n4;
            /*                 TREEE       
             *                   4
             *                 /   \
             *                3     2
             *              /        \
             *             6           1
             * 
             * 
             */

            LevelOrder(root);

        }
    }
}
