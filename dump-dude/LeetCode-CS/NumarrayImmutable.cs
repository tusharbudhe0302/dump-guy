using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    class NumarrayImmutable
    {
        int[] zeroBasedSum;
        public NumarrayImmutable(int[] nums)
        {
            this.zeroBasedSum = new int[nums.Length];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
               sum += nums[i];
                zeroBasedSum[i] = sum;
            }
        }
        public int SumRange(int i, int j)
        {
            return zeroBasedSum[j] - (i - 1 < 0 ? 0 : zeroBasedSum[i - 1]);

        }
    }
}
