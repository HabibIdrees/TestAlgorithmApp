using AngleSharp.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithmApp.Algorithms
{
    public class BasicCalculator
    {
        /*
         * Step 1: find Order of operations -> go through string and find first operation to equate
         * Step 2: Return string with new equation considering operation was executed.
         * Step 3: Repeat until no Operations are remaining unless numericals are negative
         * 
         * 
         *  Input: "3+2*2"
         *  Output: 7
         *  
         * 
         * 
         * 
         * 
         * 
         */
        public string Calculate(string equation)
        {
            String answer;
            if (equation.Length.Equals(0))
                return "String is empty";
            answer = PEMDAS(equation);

            return answer;
        }


        public  string PEMDAS(string equation)
        {
            
                double x;
              

                if (equation.Contains("*"))
                {
                int ind;
                ind = equation.IndexOf("*");


                    double y = Convert.ToDouble(equation.Substring(ind - 1,1));
                    double z = Convert.ToDouble(equation.Substring(ind + 1,1));

                if (y.Equals(0) && z.Equals(0))
                {
                    return equation;
                }
                x = y * z;
                        equation = equation.Replace(equation.Substring(ind - 1,3), x.ToString());
                    return PEMDAS(equation);
                }
                else if (equation.Contains("/"))
                {
                int ind;
                ind = equation.IndexOf("/");

                double y = Convert.ToDouble(equation.Substring(ind - 1, 1));
                double z = Convert.ToDouble(equation.Substring(ind + 1, 1));
                if (y.Equals(0) && z.Equals(0))
                {
                    return equation;
                }
                x = y / z;
                    equation = equation.Replace(equation.Substring(ind - 1, 3), x.ToString());
                return PEMDAS(equation);
                }
                else if (equation.Contains("+"))
                {
                int ind;
                ind = equation.IndexOf("+");
                double y = Convert.ToDouble(equation.Substring(ind - 1, 1));
                double z = Convert.ToDouble(equation.Substring(ind + 1, 1));
                if (y.Equals(0) && z.Equals(0))
                {
                    return equation;
                }

                x = y + z; 
                    equation = equation.Replace(equation.Substring(ind - 1, 3), x.ToString());
                return PEMDAS(equation);
                }
                else if (equation.Contains("-"))
                {
                int ind;
                ind = equation.IndexOf("-");
                double y = Convert.ToDouble(equation.Substring(ind - 1, 1));
                double z = Convert.ToDouble(equation.Substring(ind + 1, 1));
                if (y.Equals(0) && z.Equals(0))
                {
                    return equation;
                }
                x = y - z;
                equation = equation.Replace(equation.Substring(ind - 1, 3), x.ToString());
                    System.Console.WriteLine(equation);
                return PEMDAS(equation);

                }
                else
                    return equation;


        }
        /*

        public static void Main(String[] args)
        {
            BasicCalculator test = new BasicCalculator();
            string eq = "1*2+2-1";
            string results = "";

            results = test.Calculate(eq);
            System.Console.WriteLine(results);


        }
        */
    }
}
