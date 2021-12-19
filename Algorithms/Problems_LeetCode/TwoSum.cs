using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithmApp.Algorithms.Problems_LeetCode
{
    public class TwoSum
    {
        /********************************
         *
         *  
         * - Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

           - You may assume that each input would have exactly one solution, and you may not use the same element twice.

           - You can return the answer in any order

            Input:
            Input: nums = [3,2,4], target = 6
            Output: [1,2]
         * 
         * 
         *******************************/
        /*
        public int[] TwoSumReturnIndices(int[] nums, int target)
        {









        }


*/

        //ON^2
        public int[] InsertionSort(int[] arr)
        {

            int size = arr.Length;
            int[] tempArr = new int[size];
            for (int i = 1; i < size; i++)
            {
                int key = arr[i];
                int k = i - 1;
                //Validate k is not lesser than 0 to avoid out of bound exception,
                //and checks to see if predecessor element is greater than current key
                //If current predecessor  is greater than current key, swap
                while (k >= 0 && arr[k] > key)
                {
                    arr[k + 1] = arr[k];
                    k = k - 1;

                }
                //current key is placed to the next element 
                arr[k + 1] = key;
            

            }


            return arr;

        }














    }
}
