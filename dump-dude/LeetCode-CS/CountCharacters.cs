using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    class CountCharacters
    {
        /// <summary>
        /// Array Should Only if matches to chars Param
        /// </summary>
        /// <param name="words">["hat","cat","mat","leetcode","eat"]</param>
        /// <param name="chars">hcmaaetat</param>
        /// <returns>  ["hat","cat","mat"]</returns>
        public int Countcharacters(string[] words, string chars)
        {
            Dictionary<char,int> map = new Dictionary<char,int>();
            int q=0;
            foreach (char ch in chars.ToCharArray())
            {
                if(!map.ContainsKey(ch))
                map.Add(ch, q++);
            }
            Stack<string> stack = new Stack<string>();

            foreach (string str in words)
            { 
                stack.Push(str);
                foreach (char chtemp  in str.ToCharArray())
                {
                    if (!map.ContainsKey(chtemp))
                    {
                        stack.Pop();
                        break;
                    }
                }
            }
            int length = 0;
            while (stack.Count >  0)
            {
                string currentString = stack.Peek();
                length += currentString.Length;
                stack.Pop();
            }
            return length;
        }
    }
}
