using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    class SwapLongestRepeatedCharacterSubstring
    {
        /// <summary>
     /// Given a string text, we are allowed to swap two of the characters in the string. Find the length of the longest substring with repeated characters.

        //        Example 1:

        //Input: text = "ababa"
        //Output: 3
        //Explanation: We can swap the first 'b' with the last 'a', or the last 'b' with the first 'a'. Then, the longest repeated character substring is "aaa", which its length is 3.
        //Example 2:

        //Input: text = "aaabaaa" left - 1231123 right 1231123
        //Output: 6
        //Explanation: Swap 'b' with the last 'a' (or the first 'a'), and we get longest repeated character substring "aaaaaa", which its length is 6.
        //Example 3:

        //Input: text = "aaabbaaa" left 12312123 rightr 12311123
        //Output: 4
        //Example 4:

        //Input: text = "aaaaa"
        //Output: 5
        //Explanation: No need to swap, longest repeated character substring is "aaaaa", length is 5.
        /// </summary>
        /// <param name="text">aaabaaa</param>
        /// <returns></returns>

        public int MaxRepOpt1(string text)
        {
            char[] charItem = text.ToCharArray();
            int[] freq = new int[26];
            int[] left = new int[text.Length];
            int[] right = new int[text.Length];
            int maxLength = 0;
            for (int i = 0; i < text.Length; i++)
            {
                freq[charItem[i] - 'a']++;
                if (i > 0)
                {
                    if (charItem[i - 1] == charItem[i])
                    {
                        left[i] = left[i - 1] + 1;
                    }
                    else
                    {
                        left[i] = 1;
                    }
                }
                else
                {
                    left[i] = 1;
                }
                maxLength = Math.Max(maxLength, left[i]);
            }
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (i < text.Length - 1)
                {
                    if (charItem[i + 1] == charItem[i])
                    {
                        right[i] = right[i + 1] + 1;
                    }
                    else
                    {
                        right[i] = 1;
                    }
                }
                else
                {
                    right[i] = 1;
                }

            }
            int j;
            for (j = 1; j < text.Length-1; j++)
            {
                if ((charItem[j - 1] == charItem[j + 1]) && (charItem[j - 1] != charItem[j]))
                {
                    if (freq[charItem[j-1]-'a'] == left[j - 1] + right[j + 1])
                    {
                        maxLength = Math.Max(maxLength, left[j - 1] + right[j + 1]);
                    }
                    else
                    {
                        maxLength = Math.Max(maxLength, left[j - 1] + right[j + 1] + 1);
                    }
                }
                else
                {
                    if (freq[charItem[j]-'a'] == left[j])
                    {
                        maxLength = Math.Max(maxLength, left[j]);
                    }
                    else
                    {
                        maxLength = Math.Max(maxLength, left[j] + 1);
                    }
                }
            }
            return maxLength;
        }
    }
}
