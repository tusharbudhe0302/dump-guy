using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    class solution
    {
        List<int> number = new List<int>();
        Random rnd = new Random();
        public solution()
        {
            
        }
        internal List<int> CreateRandomNumber()
        {
            Random rd = new Random();
            Console.WriteLine("Dummy Array");
            for (int i = 0; i < number.Count; i++)
            {
                int currentNumber = rd.Next();
                Console.Write(currentNumber + " ");
                number.Add(currentNumber);
            }
            Console.WriteLine();
            return number;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            return null;
        }

        public int[,] MultiplicationOfTwoDimetionArray(int [,] arrayA, int[,] arrayB)
        {
            int[,] result;
            if(arrayA.GetLength(1) != arrayB.GetLength(0))
            {
                Console.WriteLine("Invalid array");
                result = null;
                return result;
            }
            result = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
            int array1Rows = arrayA.GetLength(0);
            int array2Columns = arrayB.GetLength(1);
            int kMax = arrayA.GetLength(1);
            for (int row = 0; row < array1Rows; row++)
            {
                for (int col = 0; col < array2Columns; col++)
                {
                
                    int sum = 0;
                    result[row, col] = 0;
                    // result[i,j] = array1[row,1]*array2[1,col] + array1[row,2]*array2[2,col]+array1[row,3]*array2[3,col]
                    // k < array1Rows; Either You can take rows Of Array1 Or Column of Array2 Your Choice
                    for (int k = 0; k < kMax; k++)
                    {
                        sum  = sum + ( arrayA[row, k] * arrayB[k, col]);
                    }
                    result[row, col] = sum;
                }
            }
             return result;
        }
    }
}
