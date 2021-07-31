using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithmApp.Algorithms
{
    public class Fibonacci
    {


        public static int ReturnNthOfFibonacci(int n)
        {

            if (n == 0 || n == 1 )
            {
                return n;
            }

            else
                return ReturnNthOfFibonacci(n-1) + ReturnNthOfFibonacci(n-2);

        }

		/**************************************************************************************************************************************************
                                                                                                         Nth Recursion Tree
																								--------------------------------------

                                                                                                ReturnNthOfFibonacci(int n )  where n = 6


																										Fib of n = 6  is 8

																									ReturnNthOfFibonacci( 6 )
																									/                      \
																								   5   			+			3	
							
														ReturnNthOfFibonacci(5)																ReturnNthOfFibonacci(4)
														/			 \																			/			\
													   3       +	  2																			2      + 	 1
										ReturnNthOfFibonacci(4)  																			ReturnNthOfFibonacci(3) 
										/			\																							/			\
									   2      + 	 1													 									   1	  +      1
								ReturnNthOfFibonacci(3)   																					ReturnNthOfFibonacci(2)  
								/			\																										/		\
							   1	+        1																								    	1	+	 0
							ReturnNthOfFibonacci(2)  																						ReturnNthOfFibonacci(1) 
							/		\																											/
						   1	+	 0																										Base case
						ReturnNthOfFibonacci(1) 
							/
					Base case
  
         * **********************************************************************************************************************************************************/

		//test Method
		/*
		static void Main(string[] args)
		{
			int result;
			int n = 10;
			result = ReturnNthOfFibonacci(n);

			Console.WriteLine("If N is: "+ n + " the Fibinocci of n equals : " + result );





		}
		*/


		}
}
