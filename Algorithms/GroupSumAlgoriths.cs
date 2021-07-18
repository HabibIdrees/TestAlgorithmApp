using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithmApp
{
    public class GroupSumAlgoriths
    {

        //Given an array of sorted integers and a number k. Check if there is a pair of integers in the array that sums to K.
       // Return true or False.Also mention the Time and Space complexity of your problem
       // example:sorted integers = {1,3,5,8,10,15}
       // int k = 6; aka target


        public static bool TwoSumSorted(int[] src, int target)
        {
            int left = 0; //O(1)
            int right = src.Length-1;//O(1)

            if (src.Length == 0)
            {
                return false;
            }

            for (int i =0;i<src.Length-1;i++) //O(n)
            {

                if (src[left] + src[right] == target) //O(n log n)
                {

                    return true;

                }
                else if ((src[left] + src[right]) > target) // O(n log n)
                {
                    right--;
                }
                else if ((src[left] + src[right]) < target) //O(n log n)
                {
                    left++;
                }

            }

            //1 + 1 + 3n + 1 = 3 +3n = n 

            return false;
        }


        //Return a pair of the indices

        public static int[] TwoSumSortedReturnPair(int[] src, int target)
        {
            int left = 0; //O(1)
            int right = src.Length - 1;//O(1)
            int[] pair = new int[2];

            if (src.Length == 0)
            {
                return pair;
            }

            for (int i = 0; i < src.Length - 1; i++) //O(n)
            {

                if (src[left] + src[right] == target) //O(n log n)
                {
                    pair[0] = src[left];
                    pair[1] = src[right];
                    return pair;

                }
                else if ((src[left] + src[right]) > target) // O(n log n)
                {
                    right--;
                }
                else if ((src[left] + src[right]) < target) //O(n log n)
                {
                    left++;
                }

            }

            //1 + 1 + 3n + 1 = 3 +3n = n 

            return pair;
        }


        //Unsorted brute Force
        public static bool TwoSumUnSorted(int[] src, int target)
        {
            bool result = false;

            for (int i= 0;i <=src.Length-1; i++)
            {
                for (int j =src.Length-1; j>i; j--)
                {
                    if (src[i] + src[j] == target)
                    {
                        result = true ;
                    }
                }

            }


            return result;

        }

        //Unsorted brute Force
        public static int[] TwoSumUnSortedReturnPair(int[] src, int target)
        {
            int[] pair = new int[2];

            for (int i = 0; i <= src.Length - 1; i++)
            {
                for (int j = src.Length - 1; j > i; j--)
                {
                    if (src[i] + src[j] == target)
                    {
                        
                        pair[0] = src[i];
                        pair[1] = src[j];
                        return pair;
                    }
                }

            }


            return pair;

        }
        
        //unsorted Optimized
        public static bool TwoSumUnSortedOptimized(int[] src, int target)
        {
            bool result;
            //sort array using merge sort 
            int[] sortedSrc = MergeSort(src);

           result =  TwoSumSorted(sortedSrc, target);

            return result;
        }

        //unsorted optimized pair

        public static int[] TwoSumUnSortedReturnPairOptimized(int[] src, int target)
        {
            int[] pair = new int[2];
            int[] sortedSrc = MergeSort(src);

           pair = TwoSumSortedReturnPair(sortedSrc,target);

            return pair;
        }


        public static int[] MergeSort(int[] arr)
        {
            int[] left;
            int[] right;
            int[] result = new int[arr.Length];

            //base case
            //avoid an infinite recursion/stack overflow
            if (arr.Length <= 1)
                return arr;
            // Midpoint Array 
            int midPoint = arr.Length / 2;
            //Left array
            left = new int[midPoint];

            //Handles Even array
            if (arr.Length % 2 == 0)
                right = new int[midPoint];
            //Handles Odd Array
            else
                right = new int[midPoint + 1];
            //Populate left array
            for (int i = 0; i < midPoint; i++)
                left[i] = arr[i];
            //Populate right array   
            int x = 0;
            //We start our index from the midpoint, as we have already populated the left array from 0 to midpont
                for (int i = midPoint; i < arr.Length; i++)
            {
                right[x] = arr[i];
                x++;
            }
            //Recursively sort the left array
            left = MergeSort(left);
            //Recursively sort the right array
            right = MergeSort(right);
            //Merge our two sorted arrays
            result = Merge(left, right);
            
            return result;
        }

        public static int[] Merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            //
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            //while either array still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                //if both arrays have elements  
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else the item in the right array wll be added to the results array
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }

    }
}
