using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithmApp.Algorithms.Test
{
    public class FindDictionaryWords
    {

        // Pre-knowledge
        // Given a a string and a word dict , find all possible sentences that can be formed using the words in the senetences
        //Step create a method where the input params will be a string(sentence) and an array(Dictionary) and will return an array of strings.
        //Method Logic
        /*
         * Step 1: compare first element in dictionary array to the sentence
         *          a. String.Contains("word") if true, note the length of the word and create a substring returning the remainder of the sentence with a space after the first found word.
         *
         *          b.Repeat above process untill all possible sentences are found.
         * 
         * 
         * Example: 
         * 
         * string S = "catsanddog";
         * string[] wordDict = {"cat","cats","and","sand", "dog"};
         * 
         * 
         * 
         * 
         * Type of problem - Word break 2
         * 
         * 
         * try solving by doing it by recursion
         * create a helper function
         * 
         */

        /*

        public static string[] GenerateSentences(string s, string[] wordDict)
        {
            string[] result;
            int totalWords = wordDict.Length;
            StringBuilder temp = new StringBuilder();
            bool end = true;
            int i = 0;

            while (end)
            {
                //If  string contains word, we add to stringbuilder and append a " " 
                if (s.Contains(wordDict[i]))
                {
                    temp.Append(s.Replace(wordDict[i], wordDict[i] + " "));
                    int delimit =temp.Length;
                    if (s.Length > 0)
                        s = s.Substring(delimit - 1, s.Length - delimit);
                    else
                        break;
                }

            }






            return result;
        }



        */


    }
}
