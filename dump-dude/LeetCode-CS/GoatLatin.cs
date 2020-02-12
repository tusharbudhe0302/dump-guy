using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    class GoatLatin
    {
        public string ConvertGoatLanguage(string str)
        {
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var arrayOfManSpak = str.Split(' ');
            StringBuilder sb = new StringBuilder();
            int count = 0;
            foreach (var strCopmare in arrayOfManSpak)
            {
                var charArray = strCopmare.ToCharArray();
                if (vowels.IndexOf(charArray[0]) >= 0)
                {
                    sb.Append(strCopmare + "ma ");
                    count++;
                }
                else
                {
                    string firstChar = charArray[0].ToString();
                    string removefirstChar = strCopmare.Substring(1);
                    sb.Append(removefirstChar + firstChar + "ma");
                    while (count > 0)
                    {
                        sb.Append("a");
                        count--;
                    }
                    sb.Append(" ");
                }
            }
            while (count > 0)
            {
                sb.Append("a");
                count--;
            }

            return sb.ToString();
        }
        public string ToGoatLatin(string S)
        {
            var words = S.Split(' ');
            int count = 0;
            List<char> vowelList = new List<char> { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'};
            StringBuilder sb = new StringBuilder();
            foreach (string word in words)
            {
                count++;
                if (vowelList.Contains(word[0]))
                {
                    sb.Append(word);
                }
                else
                {
                    for (int i = 1; i < word.Length; i++)
                    {
                        sb.Append(word[i]);
                    }
                    sb.Append(word[0]);
                }
                sb.Append("ma");
                for (int i = 0; i < count; i++)
                    sb.Append('a');
                // skip space for the last word
                if (count < words.Length)
                    sb.Append(' ');
            }
            return sb.ToString();

        }
    }
}
