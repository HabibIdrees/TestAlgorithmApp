using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithmApp.Algorithms
{
    public class PowerSet
    {
        // Set = a group of elements that do not repeat


        //test Method
        /*
        static void Main(string[] args)
        {
            
            int[] n = { 1, 2, 3 };

            PrintPowerSet(n);



        }
        */

        public static void PrintPowerSet(int[] arr)
        {

            int[] outputArr = new int[arr.Length];
            PrintPowerSet(arr, read: 0 , outputArr,write: 0);

        }

        public static void PrintPowerSet(int[] arr, int read, int[] outputArr, int write)
        {

            //base case ;
            if(read == arr.Length)
            {
                Console.Write("{");
                //print the set
                for (int i =1; i<write; i++)
                {
                    Console.Write(outputArr[i]);
                    Console.Write(",");

                }

                Console.Write("}");
                return;

            }


            //recurse case
            //select
            outputArr[write] = arr[read];
            PrintPowerSet(arr, read: read+1, outputArr, write: write+1);

            //dont select
            PrintPowerSet(arr, read: read+1, outputArr, write);

        }

    }
}
