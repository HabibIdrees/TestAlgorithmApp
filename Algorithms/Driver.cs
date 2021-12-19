using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAlgorithmApp.Algorithms.Trees;
using TestAlgorithmApp.Algorithms.Problems_LeetCode;

namespace TestAlgorithmApp.Algorithms
{
    public class Driver
    {


        
        public static void Main(String[] args)
        {
            /*
            string word = "agfhgsdxczoi";
            string word1 = "habib";


            int result1 = SumOfWord(word);
            int result2 = SumOfWord(word1);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            */

            TwoSum test = new TwoSum();
            int[] arr = new int[] {99,80,30,20,1,8,3,101 };
            test.InsertionSort(arr);


        }


        public static int SumOfWord(string word)
        {
            /*
             *   Requirements
                -Vowels = 2 points
                -consenants = 1 point
            -
            */
            char[] vowels = { 'A', 'I', 'O', 'U'};
            char[] vowelsLower= {  'a', 'i', 'o','u'};
            char[] charArr = word.ToCharArray();
            int result =0;
            int vowelsfound = 0;
            int consanents=0;
            for (int i =0;i<charArr.Length;i++)
            {
                for (int j =0;j<vowels.Length;j++) 
                {
                    if (charArr[i].Equals(vowels[j]) || charArr[i].Equals(vowelsLower[j]))
                    {
                        vowelsfound += 1;
                        break;
                    }

                }

            }

            consanents = word.Length - vowelsfound;
            result = consanents + (vowelsfound * 2);

            return result;
        }

        

    }
}
