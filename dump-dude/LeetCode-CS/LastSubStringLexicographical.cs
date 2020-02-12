using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    /// <summary>
    /// 1163. Last Substring in Lexicographical Order
    //Hard
    //31
    //107
    //Favorite
    //Share
    //Given a string s, return the last substring of s in lexicographical order.
    //Example 1:
    //Input: "abab"
    //Output: "bab"
    //Explanation: The substrings are["a", "ab", "aba", "abab", "b", "ba", "bab"]. The lexicographically maximum substring is "bab".
    //Example 2:
    //Input: "leetcode"
    //Output: "tcode"
    /// </summary>
    class LastSubStringLexicographical
    {
        public string LastSubstring(string str)
        {   
            string mx = "";
            for(int i =0; i < str.Length; i++)
            {
                if (mx.CompareTo(str.Substring(i)) <= 0)
                {
                    mx = str.Substring(i);
                    //mx = abab  i =0
                    //mx = bab  i =1 It should never fo into loop.

                    //Console.WriteLine(" String  " + mx + " Index " + i);
                }
            }
            return mx;
        }
    }
}
