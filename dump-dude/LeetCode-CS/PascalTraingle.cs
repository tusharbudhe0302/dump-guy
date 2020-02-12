using System;
using System.Collections.Generic;

namespace LeetCode_CS
{
    class PascalTraingle
    {
        public IList<IList<int>> Generate(int numRows)
        {

            var pascalTraingel = new List<IList<int>>();
            int[] previousRow = new int[1] { 1 };
            pascalTraingel.Add(previousRow);
            for (int i = 2; i <= numRows; i++)
            {
                int[] currentRow = new int[i];
                currentRow[0] = 1;
                int midPoint = (int)Math.Ceiling(i / 2.0) - 1;
                for (int j = 1; j <= midPoint; j++)
                {
                    currentRow[j] = previousRow[j] + previousRow[j - 1];
                }
                int destinationIndex = midPoint + 1;
                int length = i - midPoint - 1;
                Array.Copy(currentRow, 0, currentRow, destinationIndex, length);
                Array.Reverse(currentRow, destinationIndex, length);
                pascalTraingel.Add(currentRow);
                previousRow = currentRow;
            }
            return pascalTraingel;
        }
        }
}
