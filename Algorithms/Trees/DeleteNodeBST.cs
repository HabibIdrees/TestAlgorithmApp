using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithmApp.Algorithms.Trees
{
    /*
Prerequisite Search for a value in BST
Prerequisite Insert node in a BST
 */
    public class DeleteNodeBST
    {
      
        public static Node deleteNodeBST(Node node, int val)
        {
            if (node == null)
            {  // if tree is empty
                return null;
            }

            //Start searching
            if (val < node.val)
            {
                node.left = deleteNodeBST(node.left, val);
            }
            else if (val > node.val)
            {
                node.right = deleteNodeBST(node.right, val);
            }
            else
            {   // found the node.
                /*
                if(node.left == null && node.right == null) { // left node
                    return null;
                }
                 */

                if (node.left == null)
                { // takes care of both cases where it is a leaf node and or only right exist
                  // free(node);
                    return node.right; // give my right child to my parent
                }
                else if (node.right == null)
                {
                    return node.left;
                }
                else
                {  //has both child
                    int minVal = MinValue(node.right);  // or maxValue(node.left)
                    node.val = minVal;

                    node.right = deleteNodeBST(node.right, minVal); // recursively delete the minValue node

                }
            }
            return node;

        }

        /*
        Get the minimum value from a BST
         */
        public static int MinValue(Node node)
        {
            int minValue = node.val;
            for (; node != null; node = node.left)
            {
                minValue = node.val;
            }
            return minValue;
        }

        /*
        if(val == node.val) {
        } else if(val < node.val) {
        } else { // means val > node.val
        }
         */
    }
}
