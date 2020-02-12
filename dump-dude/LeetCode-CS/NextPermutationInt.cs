using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    class NextPermutationInt
    {
        //        Implement next permutation, which rearranges numbers into the lexicographically next greater permutation of numbers.

        //If such arrangement is not possible, it must rearrange it as the lowest possible order(ie, sorted in ascending order).

        //The replacement must be in-place and use only constant extra memory.

        //Here are some examples.Inputs are in the left-hand column and its corresponding outputs are in the right-hand column.

        //1,2,3 → 1,3,2
        //3,2,1 → 1,2,3
        //1,1,5 → 1,5,1
        public void NextPermutation(int[] num)
        {
            var vioIndex = FindVioIndex(num);

            // step 2
            var rightIndex = FindRightIndex(num, ref vioIndex);
            Console.WriteLine("vioIndex " + vioIndex + "rightIndex " + rightIndex);
            // step 3
            Swap(ref num[vioIndex], ref num[rightIndex]);

            // step 4
            ReverseFromVioIndexToEnd(num, vioIndex);
        }
        private static void ReverseFromVioIndexToEnd(int[] num, int vioIndex)
        {
            vioIndex++;
            var end = num.Length - 1;
            while (end > vioIndex)
            {
                Swap(ref num[vioIndex], ref num[end]);
                end--;
                vioIndex++;
            }
        }

        private static int FindRightIndex(int[] num, ref int vioIndex)
        {
            var rightIndex = num.Length - 1;
            if (vioIndex > 0)
            {
                vioIndex--;
                while (rightIndex >= 0 && num[rightIndex] <= num[vioIndex])
                {
                    Console.WriteLine("rightIndex " + rightIndex + " value " + num[rightIndex]);
                    rightIndex--;
                }
            }
            Console.WriteLine("rightIndex " + rightIndex);
            return rightIndex;
        }
        private static int FindVioIndex(int[] num)
        {
            var vioIndex = num.Length - 1;
            while (vioIndex > 0)
            {
                if (num[vioIndex - 1] < num[vioIndex])
                {

                    Console.WriteLine("vioIndex " + vioIndex + " value " + num[vioIndex]);
                    return vioIndex;
                }
                vioIndex--;
            }
            Console.WriteLine("vioIndex " + vioIndex);
            return vioIndex;
        }

        private static void Swap(ref int a, ref int b)
        {
            var swap = a;
            a = b;
            b = swap;
        }
    }
}
