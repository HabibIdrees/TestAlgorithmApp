using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithmApp.Algorithms
{
    public class Permutation
    {
        /***********************************************************************************
         *  Permutation:
         *  
         *  N elements -> n! 
         *  
         *  Example: n =3  -> 3 x 2 x 1 = 6  possible combinations
         *  
         * array = {1,2,3} --> ( {1,2,3} , {3,2,1}, {2,1,3}, {3,1,2} , {1,3,2}, {2,3,1}, {1,3,2} )
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         *********************************************************************************/
        /*
        public static void Main(String[] args)
        {
            int[] arr = { 5, 6, 7 };
            Permutations(arr);

        }
        */
        public static void Permutations(int[] arr)
        {
            Permutations(arr, 0);

        }
        public static void Permutations(int[] arr, int i)
        {
            if (i == arr.Length)
            {
                for (int k = 0; k < arr.Length; k++)
                {
                    if (k % 3 == 0)
                    {
                        Console.WriteLine();
                    }
                    Console.Write(arr[k].ToString());
                  
                }
            }

            for (int j = i; j < arr.Length; j++)
            {
                Swap(arr, i, j);
                Permutations(arr, i: i + 1);
                Swap(arr, i, j);// Back tracking 
            }

        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}