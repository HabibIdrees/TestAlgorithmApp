using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithmApp.Algorithms.Stacks
{
    public class StackValidation
    {


        public bool validateStackSequences(int[] pushed, int[] popped)
        {
            Stack<int> s = new Stack<int>();
            int j = 0;
            for (int i = 0; i < pushed.Length; i++)
            {
                s.Push(pushed[i]);
                Console.WriteLine("Pushed "+ pushed[i] + " into stack 1");
                while (s.Count > 0 && s.Peek() == popped[j])
                {
                    Console.WriteLine("Popped of stack "+ s.Pop()+ "  into Stack 2");
                    j++;
                }
            }
            if (s.Count == 0) 
                return true;

            return false;
        }



     






    }
    public class driver{

        /*
        public static void Main(String[] args)
        {
            StackValidation test = new StackValidation();
            int[] pushed = { 1, 2, 3, 4, 5 };
            int[] popped = { 4, 3, 5, 1, 2 };

            bool results;
            results = test.validateStackSequences(pushed, popped);


            System.Console.WriteLine(results);


        }

        */
    }
  


}
