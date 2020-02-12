using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    class ProductOfArrayItSelf
    {
        
        // Given an array nums of n integers where n > 1,  return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].

        //Example:
        //Input:  [1,2,3,4] left [1,1,2,6] right [24,12,4,1]
        //        Output: [24,12,8,6]
        //        Note: Please solve it without division and in O(n).

        //Follow up:
        //Could you solve it with constant space complexity? (The output array does not count as extra space for the purpose of space complexity analysis.)
        internal int[] ProductOfArray(int[] prod, int length)
        {
            
            if (length <= 0) return null;
            int i, j, k;
            int[] left = new int[length];
            int[] right = new int[length];
            int[] product = new int[length];
            left[0] = 1;
            right[length - 1] = 1;
            for (i = 1; i < length; i++)
            {
                left[i] = prod[i - 1] * left[i - 1];
            }
            for (j = length - 2; j >= 0; j--)
            {
                right[j] = prod[j + 1] * right[j + 1];
            }
            for (k = 0; k < length; k++)
            {
                product[k] = left[k] * right[k];
            }
            return product;
        }

        internal int[] ProductOfArrayMemoryOptimization(int[] array, int length)
        {
            int i, temp = 1;
            int[] product = new int[length];
            for (i = 0; i < length; i++)
            {
                product[i] = temp;
                temp *= array[i];
            }
            temp = 1;
            for (i = length - 1; i >= 0; i--)
            {
                product[i] *= temp;
                temp *= array[i];
            }
            return product;
        }
    }
}
