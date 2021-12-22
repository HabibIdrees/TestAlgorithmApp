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
        
        public int[] TwoSumReturnIndices(int[] nums, int target)
        {
            int[] sortArr = InsertionSort(nums);
            int left = 0;
            int mid = sortArr.Length % 2;
            int right = sortArr.Length-1;

            for (int i =0;i<sortArr.Length; i++)
            {
                if ((sortArr[mid] + sortArr[left]) == target)
                {
                    return new int[] { sortArr[mid], sortArr[left] };
                }
                if ((sortArr[mid] + sortArr[right]) == target)
                {
                    return new int[] { sortArr[mid], sortArr[right] };
                }
                if ((sortArr[mid] + sortArr[left]) < target)
                {
                    mid++;
                }
                if ((sortArr[mid] + sortArr[right]) > target)
                {
                    right--; 
                }


            }


            return new int[] {0, 0};

        }


        //ON^2
        public int[] InsertionSort(int[] arr)
        {

            int size = arr.Length;
            for (int i = 1; i < size; i++)
            {
                int key = arr[i]; // Key to cmpare to predecessor element 
                int k = i - 1; // Predecessor
                //Validate k is not lesser than 0 to avoid out of bound exception,
                //and checks to see if predecessor element is greater than current key
                //If current predecessor  is greater than current key, swap
                while (k >= 0 && arr[k] > key)
                {
                    arr[k + 1] = arr[k];
                    //keep moving left comparing key with previous elements until k<0
                    k = k - 1;

                }
                //current key is placed to the next element 
                arr[k + 1] = key;
            

            }


            return arr;

        }














    }
}
