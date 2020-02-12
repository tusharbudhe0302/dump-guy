using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    //    Given a 2D matrix matrix, find the sum of the elements inside the rectangle defined by its upper left corner(row1, col1) and lower right corner(row2, col2).
    //304. Range Sum Query 2D - Immutable
    //Range Sum Query 2D
    //The above rectangle(with the red border) is defined by(row1, col1) = (2, 1) and(row2, col2) = (4, 3), which contains sum = 8.
    //https://assets.leetcode.com/static_assets/public/images/courses/range_sum_query_2d.png
    //Example:
    //Given matrix = [
    //  [3, 0, 1, 4, 2],
    //  [5, 6, 3, 2, 1],
    //  [1, 2, 0, 1, 5],
    //  [4, 1, 0, 1, 7],
    //  [1, 0, 3, 0, 5]
    //]

    //sumRegion(2, 1, 4, 3) -> 8
    //sumRegion(1, 1, 2, 2) -> 11
    //sumRegion(1, 2, 2, 4) -> 12
    //Note:
    //You may assume that the matrix does not change.
    //There are many calls to sumRegion function.
    //You may assume that row1 ≤ row2 and col1 ≤ col2.
    class SumRectangle
    {
        //        int[],[] matrix = new int[[3, 0, 1, 4, 2], [5, 6, 3, 2, 1], [1, 2, 0, 1, 5],[4, 1, 0, 1, 7],[1, 0, 3, 0, 5]];
        int[][] intJaggedArray;
        public SumRectangle(int[][] matrix)
        {
            intJaggedArray = matrix;
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            int sum = 0;
            int i = row1;
            while (i <= row2)
            {
                int[] currentRow = intJaggedArray[i];
                for (int j = col1; j <= col2; j++)
                {
                    sum += currentRow[j];
                }
                i++;
            }
            return sum;
        }
        public int SumRegion2(int row1, int col1, int row2, int col2)
        {
            int sum = 0;

            for (int i = row1; i <= row2; i++) { 
                for (int j = col1; j <= col2; j++)
                {
                    sum += intJaggedArray[i][j];
                }
            }
            return sum;
        }
    }
}
