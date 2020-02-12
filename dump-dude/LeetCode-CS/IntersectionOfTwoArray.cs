using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    class IntersectionOfTwoArray
    {
        public int[] checkIntersectionOfTwoArray(int[] array1, int[] array2)
        {
            /*
             * Linq has default function to find it.
             */
            //return array1.Intersect(array2).ToArray();
            List<int> results = new List<int>();
            foreach (int i in array2)
            {
                if (array1.Contains(i) && !results.Contains(i))
                {
                    results.Add(i);
                }
            }
            return results.ToArray();
        }
    }
}
