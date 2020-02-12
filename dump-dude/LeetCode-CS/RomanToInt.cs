using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    class RomanToInt
    {
        public int RomanToIntConverter(string s)
        {
            s = s.ToUpper();
            Dictionary<char, int> romanDictionary = new Dictionary<char, int>();
            romanDictionary.Add('I', 1);
            romanDictionary.Add('V', 5);
            romanDictionary.Add('X', 10);
            romanDictionary.Add('L', 50);
            romanDictionary.Add('C', 100);
            romanDictionary.Add('D', 500);
            romanDictionary.Add('M', 1000);
            char[] characterList = s.ToCharArray();
            int number = 0;
            for (int i = 0; i < characterList.Length; i++)
            {
                if (i + 1 < s.Length && romanDictionary[characterList[i]] < romanDictionary[characterList[i + 1]])
                {
                    number -= romanDictionary[characterList[i]];
                }
                else
                {
                    number += romanDictionary[characterList[i]];
                }
            }
            return number;
        }
    }
}
