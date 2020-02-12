using System;
using System.Collections.Generic;

//sort(S);
// for i=0 to n-2 do
//    a = S[i];
//    start = i+1;
//    end = n-1;
//    while (start<end) do
//       b = S[start]
//       c = S[end];
//       if (a+b+c == 0) then
//          output a, b, c;
//          // Continue search for all triplet combinations summing to zero.
//          // We need to update both end and start together since the array values are distinct.
//          start = start + 1;
//          end = end - 1;
//       else if (a+b+c > 0) then
//          end = end - 1;
//       else
//          start = start + 1;
//    end
// end
namespace LeetCode_CS
{
    class _3Sum
    {
        public List<int> SolveThreeSum(List<int> array)
        {
            for (int i = 0; i < array.Count - 2; i++)
            {
                for (int j = i + 1; j < array.Count - 1; j++)
                {
                    for (int k = i + 2; k < array.Count; k++)
                    {
                        if ((array[i] + array[j] + array[k]) == 0)
                        {
                            return new List<int> { array[i], array[j], array[k] };
                        }
                    }
                }
            }
            return null;
        }

    }
}
