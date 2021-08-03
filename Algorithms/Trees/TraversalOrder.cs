using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithmApp.Algorithms.Trees
{
    public class OrderTraversal
    {
        /*
        public static void Main(String[] args)
        {
            Node root = new Node(val:4);
            Node n1 = new Node(val:3);
            Node n2 = new Node(val:2);
            Node n3 = new Node(val:6);
            Node n4 = new Node(val:1);
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

           // PrintInOrder(root);
           
       // }
        

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

   public class Node
    {
        public int val;
        public Node left;
        public Node right;

        //constructor
        public Node(int val) => this.val = val;



    }


}
