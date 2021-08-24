using System;
namespace TestAlgorithmApp.Algorithms.Trees
{
    public class IdenticalTrees
    {


        public Boolean IsIdentical(Node node1, Node node2)
        {
            if (node1 == null || node2 == null)
            {
                return false;
            }


            if (node1.val != node2.val)
            {
                return false;
            }

            /*
                2
               /  \
              null  3

                2
               /  \
              3   null
            */

            if (node1.left == null && node2.left != null || node1.left != null && node2.left == null)
            {
                return false;
            }

            if (node1.right == null && node2.right != null || node1.right != null && node2.right == null)
            {
                return false;
            }
            /*
            isIdentical
              Tree1
                2 
               / \
              3   4

              Tree2
                2 
               / \
              3   4




            */
            Boolean isIdentical = true;
            if (node1.Left != null && node2.Left != null)
            {
                isIdentical = IsIdentical(node1.Left, node2.Left);
            }

            if (node1.Right != null && node2.Right != null)
            {
                isIdentical = isIdentical & IsIdentical(node1.Right, node2.Right);
            }

            return isIdentical;

        }


    }
}