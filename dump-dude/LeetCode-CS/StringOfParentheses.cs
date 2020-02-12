using System.Collections.Generic;
using System.Text;

namespace LeetCode_CS
{
    class StringOfParentheses
    {
        public string StringOfParenthesesReturn(string S)
        {
            Stack<char> stack = new Stack<char>();
            string maxOp = "";
            char[] SList = S.ToCharArray();
            char lastChar;
            for (int i = 0; i < S.Length; i++)
            {
                char currentChar = SList[i];
                if (currentChar == '(')
                {
                    stack.Push(currentChar);
                }
                else if (currentChar == ')')
                {
                    lastChar = (stack != null && stack.Count > 0) ? stack.Pop() : ' ';
                    if (lastChar == '(')
                    {
                        maxOp += lastChar.ToString() + currentChar.ToString();
                    }
                }
                else
                {
                    lastChar = (stack != null && stack.Count > 0) ? stack.Peek() : ' ';
                    maxOp += lastChar.ToString() + currentChar.ToString();
                }
            }
            maxOp = maxOp.Replace(" ", string.Empty);
            return maxOp;

        }
        public string LongestLavidParenthese(string S)
        {
            int balance = 0;
            IList<int> open = new List<int>();
            IList<int> close = new List<int>();
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                {
                    balance++;
                    open.Add(i);
                }
                else if (S[i] == ')')
                {
                    balance--;
                    if (balance < 0)
                    {
                        close.Add(open.Count - 1);
                    }
                    else
                    {
                        open.RemoveAt(open.Count - 1);
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            int lo = 0, lc = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                {
                    if (lo < open.Count && i == open[lo])
                    {
                        lo++;
                    }
                    else
                    {
                        sb.Append(S[i]);
                    }
                }
                else if (S[i] == ')')
                {
                    if (lc < close.Count && i == close[lc])
                    {
                        lc++;
                    }
                    else
                    {
                        sb.Append(S[i]);
                    }
                }
                else
                {
                    sb.Append(S[i]);
                }
            }
            return sb.ToString();
        }
    }
}
