using System;

namespace TestAlgorithmApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool results;
            int[] pair = new int[2];

            //sorted
            //results = GroupSumAlgoriths.TwoSumSorted( new int[] { 1, 3, 5, 8, 10, 15 },16);
            //pair = GroupSumAlgoriths.TwoSumSortedReturnPair(new int[] { 1, 3, 5, 8, 10, 15 }, 16);

            //unsorted brute
            // results = GroupSumAlgoriths.TwoSumUnSorted(new int[] { 10, 5, -1, 4, 1, 15 }, 14);
            // pair = GroupSumAlgoriths.TwoSumUnSortedReturnPair(new int[] { 10, 5, -1, 1, 15 },14);

            //unsorted optimized
            results = GroupSumAlgoriths.TwoSumUnSortedOptimized(new int[] { 10, 5, -1, 4, 1, 15 }, 14);
            pair = GroupSumAlgoriths.TwoSumUnSortedReturnPairOptimized(new int[] { 10, 5, -1, 4, 1, 15 }, 14);
            Console.WriteLine(results);
            Console.WriteLine("The pairs of indices are : " + pair.GetValue(0) + " ," + pair.GetValue(1));
        }


	}
}
