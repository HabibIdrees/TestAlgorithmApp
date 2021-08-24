using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAlgorithmApp.Algorithms.Trees;

namespace TestAlgorithmApp.Algorithms
{
    public class Driver
    {



        public static void Main(String[] args)
        {
            Node root = new Node(0);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            root.left = node1;
            root.right = node2;
            node1.left = node3;
            node2.right = node4;

            LevelOrderTraversal.LevelOrder(root); // o/p: 0, 1, 2, 3, 4
            //PrintInOrder(root);
        }






    }
}
