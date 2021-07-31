using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithmApp.Algorithms
{
    public class Palindrome
    {
        

        public static Boolean isPalin(string str)
        {
            
            //Base case always build from base case
            if (str.Length ==0 || str.Length ==1) // str.length <=1 //base case
            {
                return true;
            }

            //recurse case
            if(str.ElementAt(0) == str.ElementAt(str.Length-1))
            {
               // recursive call works inwards 
                return isPalin(str.Substring(1, str.Length - 2));//if length is 5 then str.suubstring(1,4); end point is exclusive
            }

            return false;

        }
        
    
        
        static void Main(string[] args)
        {

            string word = "11aceca11";

            bool results;

            results = isPalin(word);
            Console.WriteLine("Is "+ word + " a Palindrome? : "+ results);
        }

    }
}
