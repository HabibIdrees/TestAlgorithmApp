using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithmApp.Algorithms.Trees
{
    public class OrderTraversal
    {
  

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
