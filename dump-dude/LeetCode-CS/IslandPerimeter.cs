using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    class IslandPerimeter
    {
        //int[][] mat = new int[][]
        //    {
        //    new int[] {0, 1, 0, 0, 0},
        //    new int[] {1, 1, 1, 0, 0},
        //    new int[] {1, 0, 0, 0, 0}
        //    };

        //Console.WriteLine(findperimeter(mat)); 

        public static int numofneighbour(int[][] mat, int i, int j,int R,int C)
        {

            int count = 0;

            // UP  
            if (i > 0 && mat[i - 1][j] == 1)
            {
                count++;
            }

            // LEFT  
            if (j > 0 && mat[i][j - 1] == 1)
            {
                count++;
            }

            // DOWN  
            if (i < R - 1 && mat[i + 1][j] == 1)
            {
                count++;
            }

            // RIGHT  
            if (j < C - 1 && mat[i][j + 1] == 1)
            {
                count++;
            }

            return count;
        }

        // Returns sum of perimeter of shapes  
        // formed with 1s  
        public static int findperimeter(int[][] mat)
        {

            int perimeter = 0;

            // Traversing the matrix and   
            // finding ones to calculate   
            // their contribution.  
           int R = mat.GetLength(0);
           
            for (int i = 0; i < R; i++)
            {
                int C = mat[i].GetLength(1);
                for (int j = 0; j < C; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        perimeter += (4 - numofneighbour(mat, i, j,R,C));
                    }
                }
            }

            return perimeter;
        }
    }
}
