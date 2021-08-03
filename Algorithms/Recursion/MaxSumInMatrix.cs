using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithmApp.Algorithms
{
    public class MaxSumInMatrix
    {

        int maxSumInPath(int[][] ary)
        {
            return maxSumInPath(ary, row: 0, col: 0);
        }



        int maxSumInPath(int[][] ary, int row, int col)
        {
            //base condition ; only one cell or last cell
            if(row == ary.Length -1 && col == ary[0].Length - 1)
            {
                return ary[row][col];
            }

            //base condition 2;
            if(row == ary.Length - 1)//reacehed  bottom of the matrix
            {
                return ary[row][col] + maxSumInPath(ary,row,col: col+1);
            }

            //base condition 3;
            if(col == ary[0].Length - 1)
            {
                return ary[row][col] + maxSumInPath(ary,row: row+1, col);// take current cell value + max value from downn
            }
            /*
            //recursive case 4
            int maxFromDown = ary[row][col] + maxSumInPath(ary,row:row+1,col);
            int maxFromRight = ary[row][col] + maxSumInPath(ary, row, col + 1);
            return Math.Max(maxFromDown, maxFromRight);
            */

            return ary[row][col] + Math.Max(maxSumInPath(ary, row: row + 1, col), maxSumInPath(ary, row, col: col + 1));

        }









    }
}
