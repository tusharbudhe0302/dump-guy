using System;

namespace LeetCode_CS
{
    class SqureSortedArray
    {
        /*
         * Given an array of integers A sorted in non-decreasing order, return an array of the squares of each number, also in sorted non-decreasing order.
         Example 1:
                Input: [-4,-1,0,3,10]
                Output: [0,1,9,16,100]
        Example 2:
                Input: [-7,-3,2,3,11]
                Output: [4,9,9,49,121]
                
                Time Complexity: O(N \log N)O(NlogN), where NN is the length of A.
                Space Complexity: O(N)O(N). 
         */
        public int[] SortedSumArray(int[] nums)
        {
            int[] result = new int[nums.Length];
            int K; int FstPv, LstNv, i = 0;
            for (K=0; K < nums.Length; K++)
                if (nums[K] >= 0)
                    break;

            FstPv = K;
            LstNv = K - 1;
            int LNV, FPV;
            while (LstNv >= 0 || FstPv < nums.Length)
            {
                LNV = (LstNv >= 0) ? Math.Abs(nums[LstNv] * nums[LstNv]) : int.MaxValue;

                FPV = (FstPv <= nums.Length) ? Math.Abs(nums[FstPv] * nums[FstPv]) : int.MinValue;

                if (LNV > FPV)
                {
                    result[i] = FPV;
                    i++;
                    FstPv++;
                }
                if (LNV <= FPV)
                {
                    result[i] = LNV;
                    i++;
                    LstNv--;
                }
            }
            return result;
        }
    }
}
