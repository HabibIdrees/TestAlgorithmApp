using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithmApp.Algorithms
{
   public class StringDecomposition
    {

        /********************************************************************************
         * 
         *  ALL substring combinations of a string
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         ******************************************************************************/


        /*

        public static void Main(String[] args)
        {
            String str = "apple";

            /*
            for (int start = 0; start <str.Length-1; start++)
            {
                for (int end = start+1; end < str.Length; end++)
                {
                    String subStr = str.Substring(start, end);
                    Console.Write( subStr + " | ");
                }
                
            }
            Console.WriteLine();
            */

          //  printSubStringSets(str);

        //}
        
        
        private static void printSubStringSets(String str)
        {
            ArrayList resultList = new ArrayList();

            printSubStringSets(str, start:0, resultList); ;

        }
        private static void printSubStringSets(String str, int start,ArrayList resultList)
        {   
            if(start == str.Length)
            {
                Console.WriteLine("result: " + resultList.ToString());
                return;
            }

            for (int end = start +1; end <str.Length+1; start ++)
            {
                String subStr = str.Substring(start, end);
                resultList.Add(subStr);
                printSubStringSets(str, end, resultList);

            }
        }





    }
}
