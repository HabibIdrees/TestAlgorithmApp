using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

    }
}
